using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public static float speed = 0.2f;
    public Transform ev;
    public float desp = 0;
	public bool inMovement;
	public Rigidbody rb;

	void Start()
	{
		rb.GetComponent<Rigidbody>();
	}
	void Update () 
	{
		//Movimiento de Izquierda a Derecha
		if(Input.GetKey(KeyCode.A) && !inMovement)
		{
			transform.position -= transform.right * speed;
		}
		if (Input.GetKey (KeyCode.D) && !inMovement) 
		{
			transform.position += transform.right * speed;
		}

		// Subida y bajada del Ascensor
		if (transform.parent == ev && Input.GetKeyDown(KeyCode.S) && !inMovement && Elevador.pisos > 0) 
		{
			Elevador.pisos--;
			print (Elevador.pisos);
            desp = -0.1f;
			StartCoroutine ("Desplazamiento");
        }
        if (transform.parent == ev && Input.GetKeyDown(KeyCode.W) && !inMovement && Elevador.pisos < 15) 
		{
			Elevador.pisos++;
			print (Elevador.pisos);
            desp = 0.1f;
			StartCoroutine ("Desplazamiento");
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
		ev.transform.position += new Vector3(0, desp, 0);
	}

}
