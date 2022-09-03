using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    
    private UnityEngine.AI.NavMeshAgent agent;
    public Transform objectTransform;

    void Awake()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(objectTransform.transform.position);
    }
}
