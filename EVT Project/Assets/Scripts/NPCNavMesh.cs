using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCNavMesh : MonoBehaviour {

    [SerializeField] Transform target, nonTarget;
    [SerializeField] NavMeshAgent npc;
    [SerializeField] float updateDelay = .3f;

    void Reset()
    {
        npc = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        InvokeRepeating("FollowTarget",0f, updateDelay);
        target = null;
    }

    void FollowTarget()
    {
        npc.SetDestination(target.position);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            target = other.transform;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            target = null;
        }
    }

}
