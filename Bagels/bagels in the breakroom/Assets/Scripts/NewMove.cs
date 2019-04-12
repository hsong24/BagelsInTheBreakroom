using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class NewMove : MonoBehaviour
{
<<<<<<< HEAD
    public float speed = 400f;

    public float dashTime = .5f;
    public bool hasBoost; 
    float firstSpeed;
    private float currentTime = 0;
	public bool isFirstPlace = false;
    public Text playerPlacement;
	public float rotato = 1.18f;
=======
    public float startSpeed = 400f;
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
	public float speed;

>>>>>>> 221a8658102e9916ef970d3d92afde51e93de071
    // Start is called before the first frame update
    void Start()
    {
        hasBoost = false; //
<<<<<<< HEAD
        firstSpeed = speed; 
=======
		speed = startSpeed; 
		moveDir = new Vector3(0,0,0);
		kicking = false;
		bump = false;
>>>>>>> 221a8658102e9916ef970d3d92afde51e93de071
    }

    // Update is called once per frame
    void FixedUpdate()
<<<<<<< HEAD
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotato, 0);
        Vector3 moveDir = new Vector3(Camera.main.transform.forward.x, 0, Camera.main.transform.forward.z);
        transform.position += moveDir * speed * Time.deltaTime * Input.GetAxis("Vertical");

        if (hasBoost == true)
        {
            if (currentTime == 0)
            {
                Debug.Log("Dash");
                gameObject.GetComponent<Animator>().SetBool("Boost", true);
                speed = speed * 3;
            }
            currentTime += Time.deltaTime;
            if (currentTime > dashTime)
            {
                speed = speed / 3f;
                hasBoost = false;
                currentTime = 0;
            }
        }
=======
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
				Debug.Log("change dir");
			}

			if (currentTime == 0f)
            {
                Debug.Log("Dash");
                gameObject.GetComponent<Animator>().SetBool("Boost", true);
				speed = startSpeed * 3;
            }

            currentTime += Time.deltaTime;

            if (currentTime > dashTime)
            {
				kicking = false;
				Debug.Log("end boost");
				speed = startSpeed;
                hasBoost = false;
				currentTime = 0f;
				gameObject.GetComponent<Animator>().SetBool("Boost", false);
				moveDir = new Vector3(moveDir.x, moveDir.y,-moveDir.z);
            }
        }

		transform.position += moveDir * speed * Time.deltaTime * Input.GetAxis("Vertical");

>>>>>>> 221a8658102e9916ef970d3d92afde51e93de071
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
<<<<<<< HEAD
        ethan.GetComponent<Animator>().SetBool("Boost", true);
=======
        ethan.GetComponent<Animator>().SetTrigger("Boost");
>>>>>>> 221a8658102e9916ef970d3d92afde51e93de071
        gameObject.GetComponent<Animator>().SetBool("Boost", false);

    }

    private void BoostAnimationEndEvent()
    {
        gameObject.GetComponent<Animator>().SetBool("Boost", false);
    }
}
