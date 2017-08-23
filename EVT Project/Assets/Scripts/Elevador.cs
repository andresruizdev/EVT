using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador : MonoBehaviour {
	public Transform ascensor;
    public static int pisos = 15, ult_piso;
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
