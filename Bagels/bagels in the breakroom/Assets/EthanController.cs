using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EthanController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void BoostEnd()
    {
        gameObject.GetComponent<Animator>().SetBool("Boost", false);
    }
}
