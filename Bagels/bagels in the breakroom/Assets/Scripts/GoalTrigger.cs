using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalTrigger : MonoBehaviour
{
    public Canvas finishImage;
    public void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            Debug.Log("finish!");
            finishImage.enabled = true;
        }
    }
}
