using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCPawnNav : MonoBehaviour
{
    [SerializeField]
    private int destPoint = 0;
    private NavMeshAgent agent;

    private Vector3 randomDestination;

    private float maxwalkDistance = 50f;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = true;

        GotoNextPoint();
    }

    void GotoNextPoint()
    {

        agent.SetDestination(FindRandomPoint());

    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GotoNextPoint();
        }
    }

    Vector3 FindRandomPoint()
    {
        Vector3 direction = Random.insideUnitSphere * maxwalkDistance;

        NavMeshHit hit;
        NavMesh.SamplePosition(direction, out hit, Random.Range(0f, maxwalkDistance), 1);

        return hit.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("deter"))
        {
            GotoNextPoint();
        }
    }

}
