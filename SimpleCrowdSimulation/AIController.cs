using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public GameObject goal; //we set the goal object where we want the owner of this script to go 
                            //at the inspector
    NavMeshAgent agent;     // the owner of this script would be an agent of our navMesh of our scene
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(goal.transform.position);
    }
}