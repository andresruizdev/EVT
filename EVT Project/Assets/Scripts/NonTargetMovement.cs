using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonTargetMovement : MonoBehaviour {
    int i = 0;
    float time = 10f;
    float desp = 0.5f, speed = 0.5f;
    int nextTarget;
    void Start()
    {
        if (gameObject.tag == "Target")
        {
            Invoke("LeftMovement", 1f);
        }
        if (gameObject.tag == "Target1")
        {
            Invoke("RightMovement", 0.1f);
        }
        if (gameObject.tag == "Target2")
        {
            Invoke("Esquina1", 2f);
        }
        if (gameObject.tag == "Target3")
        {
            Invoke("Esquina2", 3f);
        }
        
    }

    void RightMovement()
    {
        nextTarget = Random.Range(0, 1);
        transform.position = new Vector3(20, 80, 16);
        Invoke("Esquina1", 5f);
    }

    void DiagonalMovement()
    {
        nextTarget = Random.Range(0, 1);
        transform.position = new Vector3(1.8f, 80, 40);
        Invoke("Esquina2", 5f);
    }

    void LeftMovement()
    {
        nextTarget = Random.Range(0, 1);
        transform.position = new Vector3(-20, 80, 16);
        Invoke("DiagonalMovement", 15f);
    }

    void Esquina1()
    {
        nextTarget = Random.Range(0, 1);
        transform.position = new Vector3(-17, 80, 16);
        Invoke("LeftMovement", 5f);
    }

    void Esquina2()
    {
        nextTarget = Random.Range(0, 1);
        transform.position = new Vector3(15, 80, 16);
        Invoke("RightMovement", 5f);
    }
}
