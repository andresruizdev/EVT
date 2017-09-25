using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCNavMesh : MonoBehaviour {

    [SerializeField] Transform target, nonTarget, cTarget1, cTarget2, cTarget3, cTarget4, player;
    [SerializeField] NavMeshAgent npc;
    [SerializeField] float updateDelay = .3f;
    public static int npcNumbers = 48;

    void Reset()
    {
        npc = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        ColorVerification();   
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
        if (other.tag == "Player" && (gameObject.tag == "NPC" || gameObject.tag == "ConvertedNPC"))
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
            else if (number == 1)
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
            else if (num == 1)
            {
                target = cTarget4;
            }
        }
    }

    void ColorVerification()
    {
        if (GetComponent<Renderer>().material.color == Color.green)
        {
            target = player;
            LessScale();
        }
    }

    void LessScale()
    {
        gameObject.transform.localScale -= new Vector3(.006f, .006f, .006f);
        Invoke("Deactive", 2f);
    }

    void Deactive()
    {
        gameObject.SetActive(false);
        npcNumbers--;
    }

}
