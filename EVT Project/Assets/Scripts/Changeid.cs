using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changeid : MonoBehaviour {

	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player") 
		{
			if (Input.GetKey (KeyCode.A))
				CameraRotationTrigger.rotateID = 1;
			if (Input.GetKey (KeyCode.D))
				CameraRotationTrigger.rotateID = 4;
		}
	}
}
