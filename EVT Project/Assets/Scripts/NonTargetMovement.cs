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
        
    }

    void RightMovement()
    {
        transform.position = new Vector3(20, 80, 16);
        Invoke("LeftMovement", 10f);
    }

    void DiagonalMovement()
    {
        transform.position = new Vector3(1.8f, 80, 40);
        Invoke("RightMovement", 10f);
    }

    void LeftMovement()
    {
        transform.position = new Vector3(-20, 80, 16);
        Invoke("DiagonalMovement", 20f);
    }


}
