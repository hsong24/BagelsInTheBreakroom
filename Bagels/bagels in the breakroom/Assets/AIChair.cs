using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
//using UnityEngine.Time;
=======
>>>>>>> 221a8658102e9916ef970d3d92afde51e93de071

public class AIChair : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent nma;
<<<<<<< HEAD
    List<Vector3> checkpoints;
    public Transform checkpointList;
    public float timer;

    [SerializeField]
    public int currWaypoint;

    [SerializeField]
    public float dist;

=======
    public Transform[] targets;

    public int currWaypoint;

>>>>>>> 221a8658102e9916ef970d3d92afde51e93de071
    // Start is called before the first frame update
    //I added this comment in AIChair - Jordan
    void Start()
    {
<<<<<<< HEAD
        checkpoints = new List<Vector3>();
        MakeCheckpoints();

        timer = 0;

        currWaypoint = 0;
        nma = GetComponent<UnityEngine.AI.NavMeshAgent>();
        nma.SetDestination(checkpoints[currWaypoint]);
=======
        currWaypoint = 0;
        nma = GetComponent<UnityEngine.AI.NavMeshAgent>();
        nma.SetDestination(targets[currWaypoint].position);
>>>>>>> 221a8658102e9916ef970d3d92afde51e93de071
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        timer += Time.deltaTime;
        dist = nma.remainingDistance;
        if (dist <= 10 && timer > 1.0f)
        {
            nma.SetDestination(checkpoints[currWaypoint+1]);
            currWaypoint++;
            timer = 0;
        }
    }

    void MakeCheckpoints() {
        foreach (Transform child in checkpointList)
        {
            checkpoints.Add(child.GetComponent<Checkpoint>().getPosition());
            Debug.Log(child.GetComponent<Checkpoint>().getPosition());
=======
        if (nma.remainingDistance <= 100)
        {
            currWaypoint++;
            nma.SetDestination(targets[currWaypoint].position);
>>>>>>> 221a8658102e9916ef970d3d92afde51e93de071
        }
    }
}
