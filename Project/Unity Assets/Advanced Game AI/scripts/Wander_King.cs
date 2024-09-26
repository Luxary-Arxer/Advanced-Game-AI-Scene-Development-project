using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Wander_King : MonoBehaviour
{

    public NavMeshAgent agent;
    //public GameObject target;
    protected int stopDistance = 2;

    public float radius = 2, offset = 10;
    public float freq = 0f;
    public float waitTime = 5.0f;

    void patroling()
    {
        Vector3 localTarget = UnityEngine.Random.insideUnitCircle * 10;
        localTarget += new Vector3(offset, 0, 0);

        Vector3 worldTarget = transform.TransformPoint(localTarget);
        worldTarget.y = 0f;

        agent.destination = worldTarget;
    }

    // Start is called before the first frame update
    void Start()
    {
        offset = 10;
        //patroling();
    }

    // Update is called once per frame
    void Update()
    {
       
        freq += Time.deltaTime;
        if (freq > waitTime)
        {
            waitTime = Random.Range(5, 10);
            if (!agent.pathPending && agent.remainingDistance < 1f)
                patroling();
            freq -= waitTime;
        }
 

    }

}


