using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerExplotion : MonoBehaviour
{
    public float Radius = 1f;
    public float Force = 15f;
    private string Player = "Player";
    public GameObject obj;
    public string NameTrigger;
    private void OnTriggerEnter(Collider other)
    {
            if (other.tag == Player)
            {
                
            }
       
    }
}
