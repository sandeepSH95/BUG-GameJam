using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wander : MonoBehaviour
{
    [SerializeField]
    private Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = true;

        GotoNextPoint();
    }

    void GotoNextPoint()
    {
        if (points.Length == 0)
        {
            return;
        }

        agent.destination = points[destPoint].position;

        destPoint = Random.Range(0, points.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GotoNextPoint();
        }
    }
}
