using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Custom/Dialogue")]
public class Dialogue : ScriptableObject
{
    [SerializeField]
    bool IsDone = false;

    public enum D_Character
    {
        Player,
        Ho,
        Jeong,
        Yoon
    };

    
    [System.Serializable]
    public class Sentence
    {
        public D_Character D_name;
        [TextArea(3,10)]
        public string[] D_text;
    }


    public bool checkDone()
    {
        return IsDone;
    }

    public void setDone()
    {
        IsDone = true;
    }
    public Sentence[] sentences;



}
