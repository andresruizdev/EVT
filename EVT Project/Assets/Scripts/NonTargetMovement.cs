using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonTargetMovement : MonoBehaviour {
    int i = 0;
    float time = 10f;
    float desp = 0.5f, speed = 0.5f;
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
        if (gameObject.tag == "Targer3")
        {
            Invoke("Esquina2", 3f);
        }
        
    }

    void RightMovement()
    {
        transform.position = new Vector3(20, 80, 16);
        Invoke("DiagonalMovement", 10f);
    }

    void DiagonalMovement()
    {
        transform.position = new Vector3(1.8f, 80, 40);
        Invoke("LeftMovement", 10f);
    }

    void LeftMovement()
    {
        transform.position = new Vector3(-20, 80, 16);
        Invoke("Esquina2", 20f);
    }

    void Esquina1()
    {
        transform.position = new Vector3(-17, 80, 16);
        Invoke("RightMovement", 20f);
    }

    void Esquina2()
    {
        transform.position = new Vector3(-15, 80, 16);
        Invoke("Esquina1", 10f);
    }


}
