using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharController : MonoBehaviour
{
	private CharacterController controller;
	public float Speed = 10.0f;
	public float JumpHeight = 2f;
	public float Gravity = -9.81f;
	public float dashTime = .5f;//
	public Vector3 Drag;

	private Vector3 _velocity;
	private bool _isGrounded = true;
    public bool hasBoost; //
    float firstSpeed;//
	private float currentTime = 0;//


	void Start()
	{
		controller = GetComponent<CharacterController>();
        hasBoost = false; //
        firstSpeed = Speed; //
	}


	void Update()
	{
		Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        /**
		if (Input.GetButtonDown("Dash") && hasBoost == false)
		{
			hasBoost = true;
		}
        **/

		controller.Move(move * Time.deltaTime * Speed);

		if (hasBoost == true) {
			if (currentTime == 0) {
				Debug.Log("Dash");
                gameObject.GetComponent<Animator>().SetBool("Boost", true);
                Speed = Speed * 3;
			}
			currentTime += Time.deltaTime;
			if (currentTime > dashTime) {
				Speed = Speed/3f;
				hasBoost = false;
				currentTime = 0;
			}
		}



		if (move != Vector3.zero)
			transform.forward = move;

		_velocity.y += Gravity * Time.deltaTime;

		controller.Move(_velocity * Time.deltaTime);
        
    }

    // This controls the animations when boosting
    private void BoostAnimationEvent()
    {
        GameObject ethan = gameObject.transform.GetChild(3).gameObject;
        ethan.GetComponent<Animator>().SetBool("Boost", true);
        gameObject.GetComponent<Animator>().SetBool("Boost", false);

    }

    private void BoostAnimationEndEvent()
    {
        gameObject.GetComponent<Animator>().SetBool("Boost", false);
    }

}