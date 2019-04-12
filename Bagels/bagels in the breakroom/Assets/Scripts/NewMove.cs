using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class NewMove : MonoBehaviour
{
    public float speed = 400f;
    public float dashTime = .5f;
    public bool hasBoost; 
    float firstSpeed;
	private float currentTime = 0f;
	public bool isFirstPlace = false;
    public Text playerPlacement;
	public float rotato = 1.18f;
	public bool kicking;
	public Vector3 moveDir;
	public bool bump = false;


    // Start is called before the first frame update
    void Start()
    {
        hasBoost = false; //
        firstSpeed = speed; 
		moveDir = new Vector3(0,0,0);
		kicking = false;
		bump = false;
    }

    // Update is called once per frame
    void FixedUpdate()
	//so the problem is you can only get currentTime in the right place or kicking in the right place
    {
        
		transform.Rotate(0, Input.GetAxis("Horizontal") * rotato, 0);
		moveDir = new Vector3(Camera.main.transform.forward.x, 0, Camera.main.transform.forward.z);
        if (hasBoost == true)
        {	
			if (bump == true) {
				currentTime = 0;
				bump = false;
			}
			if (kicking == true) {
				moveDir = new Vector3(moveDir.x, moveDir.y,-moveDir.z);

			}

			if (currentTime == 0f)
            {
                Debug.Log("Dash");
                gameObject.GetComponent<Animator>().SetBool("Boost", true);
				speed = speed * 3;
            }
			Debug.Log("before");
			Debug.Log(currentTime);
            currentTime += Time.deltaTime;
			Debug.Log("after");
			Debug.Log(currentTime);
            if (currentTime > dashTime)
            {
				kicking = false;
				Debug.Log("end boost");
				speed = speed/3;
                hasBoost = false;
				currentTime = 0f;
				gameObject.GetComponent<Animator>().SetBool("Boost", false);
				moveDir = new Vector3(moveDir.x, moveDir.y,-moveDir.z);
            }
        }

		transform.position += moveDir * speed * Time.deltaTime * Input.GetAxis("Vertical");

    }

    void Update()
    {
        if(isFirstPlace)
        {
            playerPlacement.text = "1ST";
        } else
        {
            playerPlacement.text = "2ND";
        }
    }

    // This controls the animations when boosting
    private void BoostAnimationEvent()
    {
        GameObject ethan = gameObject.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject;
        ethan.GetComponent<Animator>().SetTrigger("Boost");
        gameObject.GetComponent<Animator>().SetBool("Boost", false);

    }

    private void BoostAnimationEndEvent()
    {
        gameObject.GetComponent<Animator>().SetBool("Boost", false);
    }
}
