using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DL_right : MonoBehaviour
{
    public Text DL_text;
    public void DL_init(string text)
    {
        DL_text.text = text;
    }
}
