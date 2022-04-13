using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private string Player = "Player";
    public GameObject obj;
    public string NameTrigger;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == Player)
        {
            obj.GetComponent<Animator>().SetTrigger(NameTrigger);
        }

    }
}

   