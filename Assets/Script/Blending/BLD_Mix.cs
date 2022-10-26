using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BLD_Mix : MonoBehaviour
{
    
    public SortedSet<string> alcoholList;
    Dictionary<SortedSet<string>, string> cocktailRecipe = new Dictionary<SortedSet<string>, string>
    ()
    {
        { new SortedSet<string>() { "Ʈ���ü�","���� �ֽ�", "ũ������ �ֽ�" },"�ڽ�������ź"}
    };

    void Start()
    {
        alcoholList = new SortedSet<string>();
    }

    public void addIGD(Alcohol alcohol)
    {
        if (alcoholList.Count==0||!alcoholList.Contains(alcohol.Aname))
        {
            Debug.Log(alcohol.Aname + " �߰�");
            alcoholList.Add(alcohol.Aname);
        }
    }

    public void blendCocktail()
    {
        if (alcoholList.Count <= 0)
        {
            Debug.Log("������ ��� ����");
            return;
        }

        foreach(SortedSet<string> recipe in cocktailRecipe.Keys)
        {
            if (isEqualSet(recipe, alcoholList))
            {
                Debug.Log("Ĭ���� ���� �Ϸ� : " + cocktailRecipe[recipe]);
                alcoholList.Clear();
                return;
            }
        }
        Debug.Log("���� �� �ִ� Ĭ���� ����");
        return;
    }

    public bool isEqualSet(SortedSet<string> x, SortedSet<string> y)
    {
        if (x.Count != y.Count) return false;
        foreach(string a in x)
        {
            if (!y.Contains(a)) return false;
        }
        return true;
    }
}
