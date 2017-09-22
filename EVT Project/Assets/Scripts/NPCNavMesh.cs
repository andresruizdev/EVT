using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCNavMesh : MonoBehaviour {

    [SerializeField] Transform target, nonTarget, cTarget1, cTarget2;
    [SerializeField] NavMeshAgent npc;
    [SerializeField] float updateDelay = .3f;

    void Reset()
    {
        npc = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        
    }
    void Start()
    {
        SetTarget();
        InvokeRepeating("FollowTarget",0f, updateDelay);
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
            SetTarget();
        }
    }

    void SetTarget()
    {
        if (gameObject.tag == "Boy" || gameObject.tag == "girl")
        {
            target = cTarget1;
        }

        if (gameObject.tag == "NPC")
        {
            target = cTarget2;
        }
    }

}
