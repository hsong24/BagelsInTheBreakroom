using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform[] options;

    public Vector3 getPosition()
    {
        return options[Random.Range(0, options.Length)].position;
    }
}
