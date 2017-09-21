using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMech : MonoBehaviour {
	Color colorPre;

	void Start()
	{
		colorPre = Color.red; 
	}
	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Piso" && Input.GetKey(KeyCode.Space)) 
		{
			other.GetComponent<Renderer> ().material.color = colorPre;
		}
	}
}
