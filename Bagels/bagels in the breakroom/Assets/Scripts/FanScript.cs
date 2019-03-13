using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanScript : MonoBehaviour
{
	
	public float speed = 1000f;


	void Update ()
	{
		transform.Rotate(0,0, speed * Time.deltaTime);
	}
}
