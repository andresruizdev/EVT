using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCNavMesh : MonoBehaviour {

    [SerializeField] Transform target, nonTarget, cTarget1, cTarget2, cTarget3, cTarget4;
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
        if (other.tag == "Player" && gameObject.tag == "NPC")
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
        if (gameObject.tag == "Boy" || gameObject.tag == "Girl")
        {
            int number = Random.Range(0,1);
            if (number == 0)
            {
                target = cTarget1;
            }
            if (number == 1)
            {
                target = cTarget3;
            }
        }

        if (gameObject.tag == "NPC")
        {
            int num = Random.Range(0,1);
            if (num == 0)
            {
                target = cTarget2;
            }
            if (num == 1)
            {
                target = cTarget4;
            }
        }
    }

}
