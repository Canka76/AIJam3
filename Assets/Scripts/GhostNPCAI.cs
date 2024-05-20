using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class GhostNPCAI : MonoBehaviour
{
    public Transform Point1;
    public Transform Point2;

    private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        InvokeRepeating("PointChooser", 0, 5); // Call PointChooser method every 10 seconds starting from the beginning
    }

    private void PointChooser()
    {
        Vector3 desiredPoint = new Vector3(Random.Range(Point1.position.x, Point2.position.x),
            transform.position.y, // Keep the same Y-coordinate
            Random.Range(Point1.position.z, Point2.position.z));

        _agent.SetDestination(desiredPoint); // Set the destination for the NavMeshAgent
    }
    
    
}