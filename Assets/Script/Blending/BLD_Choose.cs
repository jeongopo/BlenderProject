using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BLD_Choose : MonoBehaviour
{
    public Alcohol alcohol;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.transform.gameObject.gameObject.name == this.name)
            {
                FindObjectOfType<BLD_Mix>().addIGD(alcohol);
            }
        }
    }
}
