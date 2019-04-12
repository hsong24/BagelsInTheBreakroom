using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickTrigger : MonoBehaviour
{
	public GameObject player;
	NewMove newMove;

	void Start() {
		newMove = player.GetComponent<NewMove>();
		Debug.Log(" csefsd");
	}
	void OnTriggerEnter(Collider col) {
		Debug.Log("tuch");
		if (col.tag == "BounceObject") {
			if (!newMove.kicking) {
			Debug.Log("Bouncy boy");
			newMove.kicking = true;
			newMove.hasBoost = true;
			newMove.bump = true;
			}
			}
		}

}
