using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject player;
    NewMove playerScript;
    public void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            Debug.Log("snatched");
            Destroy(gameObject);
            col.GetComponent<NewMove>().hasBoost = true;
        }
    }
}
