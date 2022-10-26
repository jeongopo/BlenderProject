using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DL_left : MonoBehaviour
{
    public Text DL_name;
    public Text DL_text;
    public Image DL_image;
    public void DL_init(string name,string text)
    {
        //DL_image
        DL_name.text = name;
        DL_text.text = text;
    }

}
