using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonTargetMovement : MonoBehaviour {
    public Vector3 nonTarget;
    int i = 0;
    float desp = 0.5f, speed = 0.5f;
    void Start()
    {
        nonTarget = new Vector3(desp, 0, 0);
        StartCoroutine("Escape");
    }
	void Update ()
    {
        if (i == 0)
        {
            transform.position += transform.right * speed;
        }
        if (i == 1)
        {
            transform.position -= transform.right * speed;
        }
        
	}

    IEnumerator Escape()
    {
        if (i == 0)
        {
            i++;
        }
        if (i == 1)
        {
            i--;
        }
        StartCoroutine("Escape");
        yield return new WaitForSeconds(5f);
        
    }
}
