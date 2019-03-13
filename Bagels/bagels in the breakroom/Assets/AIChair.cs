using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChair : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent nma;
    public Transform[] targets;

    public int currWaypoint;

    // Start is called before the first frame update
    void Start()
    {
        currWaypoint = 0;
        nma = GetComponent<UnityEngine.AI.NavMeshAgent>();
        nma.SetDestination(targets[currWaypoint].position);
    }

    // Update is called once per frame
    void Update()
    {
        if (nma.remainingDistance <= 100)
        {
            currWaypoint++;
            nma.SetDestination(targets[currWaypoint].position);
        }
    }
}
