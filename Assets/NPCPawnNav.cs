using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCPawnNav : MonoBehaviour
{
    private NavMeshAgent agent;

    private Vector3 randomDestination;

    private float maxwalkDistance = 10f;

    public float range = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = true;

        GotoNextPoint();
    }

    void GotoNextPoint()
    {

        //agent.SetDestination(FindRandomPoint());
        Vector3 point;
        agent.SetDestination(RandomPoint(transform.position, range, out point));

    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
           GotoNextPoint();
        }
        
    }


    //Depreciated Function
    /*
    Vector3 FindRandomPoint()
    {
        Vector3 direction = Random.insideUnitSphere * maxwalkDistance;

        NavMeshHit hit;
        NavMesh.SamplePosition(direction, out hit, Random.Range(0f, maxwalkDistance), 1);

        Debug.Log(hit.position);

        return hit.position;
    }
    */

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("deter"))
        {
            GotoNextPoint();
        }
    }


    Vector3 RandomPoint(Vector3 center, float range, out Vector3 result)
    {
        for (int i = 0; i < 30; i++)
        {
            Vector3 randomPoint = center + Random.insideUnitSphere * range;
            NavMeshHit hit;
            if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas))
            {
                result = hit.position;
                return hit.position;
            }
        }
        result = Vector3.zero;
        return result;
    }

}
