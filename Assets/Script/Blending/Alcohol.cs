using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Alcohol", menuName = "Custom/Alcohol")]
public class Alcohol : ScriptableObject
{
    public string Aname="";
    Alcohol(string name)
    {
        Aname = name;
    }
}
