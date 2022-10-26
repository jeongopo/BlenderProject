using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Linespace;

public class DLogManager : MonoBehaviour
{
    public ScrollRect scroll;
    public GameObject left_prefab;
    public GameObject right_prefab;
    Transform content;

    private void Start()
    {
        content = scroll.content.transform;
    }


    public void SetLogItems(List<D_Line> DL_sentences)
    {
        InitLogItems();
        int count = 0;
        for(int i=0;i<DL_sentences.Count;)
        {
            GameObject tem;
            string f_name = DL_sentences[i].L_name;
            string f_text = DL_sentences[i].L_text;
            count++;
            i++;

            while (i<DL_sentences.Count&&DL_sentences[i].L_name == f_name)
            {
                f_text += "\n"+ DL_sentences[i].L_text ;
                i++;
            }

            if (f_name == "플레이어")
            {
                tem = Instantiate(right_prefab, content);
                tem.GetComponent<DL_right>().DL_init(f_text);
            }
            else
            {
                tem = Instantiate(left_prefab, content);
                tem.GetComponent<DL_left>().DL_init(f_name, f_text);
            }
        }
       
        scroll.content.sizeDelta = new Vector2(1920, count * 200);

    }

    public void InitLogItems()
    {
        for(int i = 0; i < content.childCount; i++)
        {
            if (content.name != content.GetChild(i).name)
            {
                Destroy(content.GetChild(i).gameObject);
            }
        }
    }
}
