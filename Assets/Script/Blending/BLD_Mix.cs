using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BLD_Mix : MonoBehaviour
{
    
    public SortedSet<string> alcoholList;
    Dictionary<SortedSet<string>, string> cocktailRecipe = new Dictionary<SortedSet<string>, string>
    ()
    {
        { new SortedSet<string>() { "트리플섹","라임 주스", "크랜베리 주스" },"코스모폴리탄"}
    };

    void Start()
    {
        alcoholList = new SortedSet<string>();
    }

    public void addIGD(Alcohol alcohol)
    {
        if (alcoholList.Count==0||!alcoholList.Contains(alcohol.Aname))
        {
            Debug.Log(alcohol.Aname + " 추가");
            alcoholList.Add(alcohol.Aname);
        }
    }

    public void blendCocktail()
    {
        if (alcoholList.Count <= 0)
        {
            Debug.Log("선택한 재료 없음");
            return;
        }

        foreach(SortedSet<string> recipe in cocktailRecipe.Keys)
        {
            if (isEqualSet(recipe, alcoholList))
            {
                Debug.Log("칵테일 제조 완료 : " + cocktailRecipe[recipe]);
                alcoholList.Clear();
                return;
            }
        }
        Debug.Log("만들 수 있는 칵테일 없음");
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
