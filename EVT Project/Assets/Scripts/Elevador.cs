using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador : MonoBehaviour {
	public Transform ascensor;
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			print ("Collider");
			other.transform.SetParent (ascensor);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") 
		{
			other.transform.SetParent (null);
		}
	}
}
