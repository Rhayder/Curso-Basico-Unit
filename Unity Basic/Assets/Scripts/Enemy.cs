using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    public Transform[] destinationPoints;
    private NavMeshAgent agent;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(destinationPoints[index].position);

    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance < 0.5f)
        {
            index++;
            if (index >= destinationPoints.Length)
            {
                index = 0;
            }

            agent.SetDestination(destinationPoints[index].position);
        }
    }
}
