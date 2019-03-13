using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCameraScript : MonoBehaviour
{

    public Transform target;
    public float height = 8f;
    public float distance = 7;
    public float speed;

    Vector3 offset;

    void Start()
    {
        offset = new Vector3(target.position.x, target.position.y + height, target.position.z + distance);
    }

    void LateUpdate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Horizontal") * speed, Vector3.up) * offset;
        transform.position = target.position + offset;
        transform.LookAt(target.position);
    }
}
