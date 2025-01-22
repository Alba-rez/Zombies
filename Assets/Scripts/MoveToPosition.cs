using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToPosition : MonoBehaviour
{
    Transform target;
    NavMeshAgent agent;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
