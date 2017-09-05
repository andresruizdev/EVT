using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationTrigger : MonoBehaviour {
	public float desp;
	bool movimiento;
	public GameObject camera, player;
	public static int rotateID = 1;


	void Update()
	{
		
		if (Input.GetKeyDown (KeyCode.RightArrow) && !movimiento) 
		{
				desp = -0.5f;
				StartCoroutine ("Desplazar");
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow) && !movimiento) 
		{
				desp = 0.5f;
				StartCoroutine ("Desplazar");
		}
	}

	IEnumerator Desplazar()
	{
		for (int i = 0; i < 180; i++) {
			movimiento = true;
			if (movimiento) {
				Rotation ();
				yield return new WaitForSeconds (0.01f);		
			}
			movimiento = false;
		}
	}

	void Rotation()
	{
		print ("Rotacion");
		camera.transform.eulerAngles += new Vector3(0f,desp,0f);
	}
}
