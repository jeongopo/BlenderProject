using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit) && hit.transform.gameObject.gameObject.name == this.name)
            {
                FindObjectOfType<DialogueManager>().StartDialgoue(dialogue);
            }
        }
    }
}
