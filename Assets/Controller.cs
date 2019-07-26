using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Controller : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Animator>().SetTrigger("TriggerA");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Animator>().SetTrigger("TriggerB");
        }
    }
}
