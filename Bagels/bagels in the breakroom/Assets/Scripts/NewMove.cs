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
    private float currentTime = 0;
	public bool isFirstPlace = false;
    public Text playerPlacement;
	public float rotato = 1.18f;
    // Start is called before the first frame update
    void Start()
    {
        hasBoost = false; //
        firstSpeed = speed; 
    }

    // Update is called once per frame
    void FixedUpdate()
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
        ethan.GetComponent<Animator>().SetBool("Boost", true);
        gameObject.GetComponent<Animator>().SetBool("Boost", false);

    }

    private void BoostAnimationEndEvent()
    {
        gameObject.GetComponent<Animator>().SetBool("Boost", false);
    }
}
