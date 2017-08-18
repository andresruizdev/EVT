using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public static float speed = 0.2f;
    public Transform ev;
    public float desp = 0;
	void Update () 
	{
		if(Input.GetKey(KeyCode.A))
		{
			transform.position -= transform.right * speed;
		}
		if (Input.GetKey (KeyCode.D)) 
		{
			transform.position += transform.right * speed;
		}
		if (transform.parent == ev && Input.GetKeyDown(KeyCode.S)) 
		{
            desp = -0.5f;
			StartCoroutine ("Desplazamiento");
        }
        if (transform.parent == ev && Input.GetKeyDown(KeyCode.W)) 
		{
            desp = 0.5f;
			StartCoroutine ("Desplazamiento");
        }
    }

    IEnumerator Desplazamiento()
	{
        ev.transform.position += new Vector3(0, desp, 0);
        yield return new WaitForSeconds(0.05f);
        ev.transform.position += new Vector3(0, desp, 0);
        yield return new WaitForSeconds(0.05f);
        ev.transform.position += new Vector3(0, desp, 0);
        yield return new WaitForSeconds(0.05f);
        ev.transform.position += new Vector3(0, desp, 0);
        yield return new WaitForSeconds(0.05f);
        ev.transform.position += new Vector3(0, desp, 0);
        yield return new WaitForSeconds(0.05f);
        ev.transform.position += new Vector3(0, desp, 0);
        yield return new WaitForSeconds(0.05f);
        ev.transform.position += new Vector3(0, desp, 0);
        yield return new WaitForSeconds(0.05f);
        ev.transform.position += new Vector3(0, desp, 0);
        yield return new WaitForSeconds(0.05f);
        ev.transform.position += new Vector3(0, desp, 0);
        yield return new WaitForSeconds(0.05f);
        ev.transform.position += new Vector3(0, desp, 0);
    }

}
