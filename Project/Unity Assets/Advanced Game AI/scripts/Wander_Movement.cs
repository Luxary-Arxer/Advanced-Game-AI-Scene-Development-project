using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Movment_Guard : MonoBehaviour
{
    public NavMeshAgent agent;
    //public GameObject target;
    protected int stopDistance = 2;

    public float radius = 2, offset = 10;
    public float freq = 0f;
    public float waitTime = 0.1f;

    public float waitTime_Max = 3f;

    public Transform[] points;
    private int destPoint = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        agent.autoBraking = false;

        GotoNextPoint();
    }

    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (points.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = points[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % points.Length;
    }


    void Update()
    {
        // Choose the next destination point when the agent gets
        // close to the current one.

        if (agent.remainingDistance < 0.5f)
        {
            freq += Time.deltaTime;
            if (freq > waitTime)
            {
                waitTime = waitTime_Max;
                GotoNextPoint();

                freq -= waitTime;
            }
        }


        /*
        freq += Time.deltaTime;
        if (freq > waitTime)
        {
            waitTime = UnityEngine.Random.Range(waitTime_Min, waitTime_Max);
            if (agent.remainingDistance < 0.5f) { 
                GotoNextPoint(); 
            }

                
            freq -= waitTime;
        }
        */
    }
    
}


