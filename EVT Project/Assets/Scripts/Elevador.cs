﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Elevador : MonoBehaviour
{
    public GameObject blurPanel;
    public Button blue, red, yellow, cyan, magenta;
	public Transform ascensor;
	public float desp;
    bool inMovement = false;
	public static int pisos = 15, ult_piso;

    // Volver al Personaje Hijo del Ascensor tras detectar que comienza a colisionar con la plataforma
    void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			other.transform.SetParent (ascensor); 
		}
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                blurPanel.SetActive(true);
            }

            if (Input.GetKeyUp(KeyCode.LeftControl))
            {
                blurPanel.SetActive(false);
            }
        }
    }

    // Volver al Personaje indepentiente tras detectar que deja de Colisionar con la plataforma
    void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") 
		{
			other.transform.SetParent (null);
			ult_piso = pisos;
		}
	}

	//Corutina para el dezplazamiento del Ascensor
	public IEnumerator Desplazamiento()
	{
		
		inMovement = true;
		for (int i = 0; i < 50; i++) {
			Transition ();
			yield return new WaitForSeconds (0.01f);
		}
		inMovement = false;

	}

	// Cantidad de Transición durante cada repetición de la Corrutina
	public void Transition()
	{
		ascensor.transform.position += new Vector3(0, desp, 0);
	}

    
}
