using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickTrigger : MonoBehaviour
{
	public GameObject player;
	NewMove newMove;

	void Start() {
		newMove = player.GetComponent<NewMove>();
	}
	void OnTriggerEnter(Collider col) {
		if (col.tag != "Player") {
			newMove.kicking = true;
			newMove.hasBoost = true;
			newMove.bump = true;
			}
		}

}
