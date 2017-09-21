using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonTargetMovement : MonoBehaviour {
    public Vector3 nonTarget;
    int i = 0;
    float time = 10f;
    float desp = 0.5f, speed = 0.5f;
    void Start()
    {
        Invoke("LeftMovement", 0.5f);
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
