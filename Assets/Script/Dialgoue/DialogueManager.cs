using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Linespace;
namespace Linespace
{
    public class D_Line
    {
        public string L_name;
        public string L_text;
    }
}

public class DialogueManager : MonoBehaviour
{
    public GameObject D_Canvas;
    public GameObject DL_Canvas;
    public Text D_name;
    public Text D_text;
    public Image D_customer;
    public Image D_player;
    DLogManager dLogManager;

    Queue<D_Line> sentences=new Queue<D_Line>();

    public float typespeed;
    public List<D_Line> DL_sentences = new List<D_Line>();
    bool IsDialgoue = false;
    bool IsDLog = false;
    bool IsType = false;
    string currentText = "";
    IEnumerator coroutine;


    private void Start()
    {
        D_Canvas.SetActive(false);
        DL_Canvas.SetActive(false);
        dLogManager =FindObjectOfType<DLogManager>();
    }

    void Update()
    {
        if (IsDialgoue &&!IsDLog&&(Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Return)))
        {
            if (IsType)
            {
                StopCoroutine(coroutine);
                D_text.text = currentText;
                IsType = false;
                return;
            }
            nextSentence();
        }
    }

    void DialogueSetting(Dialogue p_dialgoue)
    {
        sentences.Clear();
        DL_sentences.Clear();
        D_text.text = "";
        foreach (Dialogue.Sentence s in p_dialgoue.sentences)
        {
            foreach (string l in s.D_text)
            {

                D_Line tem =new D_Line();
                switch (s.D_name)
                {
                    case Dialogue.D_Character.Player:
                        tem.L_name = "플레이어";
                        break;
                    case Dialogue.D_Character.Ho:
                        tem.L_name = "건호";
                        break;
                    case Dialogue.D_Character.Jeong:
                        tem.L_name = "현정";
                        break;
                    case Dialogue.D_Character.Yoon:
                        tem.L_name = "윤지";
                        break;
                }
                tem.L_text = l;
                sentences.Enqueue(tem);
            }
        }
    }

    public void StartDialgoue(Dialogue p_dialgoue)
    {
        DialogueSetting(p_dialgoue);
        nextSentence();
        D_Canvas.SetActive(true);
        IsDialgoue = true;
    }

    IEnumerator TypingAnim(string text)
    {
        for(int i = 0; i < text.Length; i++)
        {
            D_text.text += text[i];
            if(text[i]==' ')
            {
                FindObjectOfType<SEManager>().playChatCilp();
            }
            yield return new WaitForSeconds(typespeed);
        }
        IsType = false;
    }

    void nextSentence()
    {
        if (sentences.Count == 0)
        {
            D_Canvas.SetActive(false);
            IsDialgoue = false;
            return;
        }

        D_name.text = sentences.Peek().L_name;
        currentText = sentences.Peek().L_text;
        D_text.text = "";
        coroutine = TypingAnim(currentText);
        IsType = true;
        StartCoroutine(coroutine);


        Color D_color = D_customer.color;

        if (sentences.Peek().L_name == "플레이어")
        {
            D_color.a = 1.0f;
            D_player.color = D_color;
            D_color.a = 0.5f;
            D_customer.color = D_color;
        }
        else
        {
            D_color.a = 1.0f;
            D_customer.color = D_color;
            D_color.a = 0.5f;
            D_player.color = D_color;
        }
        DL_sentences.Add(sentences.Peek());
        sentences.Dequeue();
    }

    public void StartLogCanvas()
    {
        DL_Canvas.SetActive(true);
        dLogManager.SetLogItems(DL_sentences);
        IsDLog = true;
    }

    public void SetFalseDlog()
    {
        IsDLog = false;
    }
}
