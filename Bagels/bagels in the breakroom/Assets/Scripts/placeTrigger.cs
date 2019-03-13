using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeTrigger : MonoBehaviour
{
    // Start is called before the first frame update
	public GameObject player;
	public GameObject ai;
	NewMove playerScript;

	public void OnTriggerEnter(Collider col)
	{
		if(col.tag == "Player")
		{
			Debug.Log("player First");
			Destroy(gameObject);
			col.GetComponent<NewMove>().isFirstPlace = true;
		} else {
			Debug.Log("player second");
			Destroy(gameObject);
			player.GetComponent<NewMove>().isFirstPlace = false;
		}

	}
}
