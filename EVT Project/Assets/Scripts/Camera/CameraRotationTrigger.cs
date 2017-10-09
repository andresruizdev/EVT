using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class CameraRotationTrigger : MonoBehaviour {
    CameraMovement cameraMovement = new CameraMovement();
	bool movimiento;
	public GameObject theCamera;


	void Update()
	{
        RotationControl();
	}

	IEnumerator Desplazar() // Corrutina de desplazamiento de la cámara
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

	void Rotation() //Rotación de la Cámara
	{
		theCamera.transform.eulerAngles += new Vector3(0f,cameraMovement.desp,0f);
	}

    void RotationControl()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) &&! movimiento)
        {
            cameraMovement.desp = -0.5f; // Rotación a la derecha
            StartCoroutine("Desplazar");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && !movimiento)
        {
            cameraMovement.desp = 0.5f; // Rotación a la izquierda
            StartCoroutine("Desplazar");
        }
    }
}

public sealed class CameraMovement : Stats
{
    public CameraMovement()
    {// Hereda desp
        desp = 0;
    }
}
