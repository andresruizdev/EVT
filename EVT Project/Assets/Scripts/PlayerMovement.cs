using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public static float speed = 0.2f;
    public Transform ev;
    public float desp = 0;
    public bool inMovement;

	void Update () 
	{
        // Movimiento de Izquierda a Derecha del personaje
		if(Input.GetKey(KeyCode.A))
		{
			transform.position -= transform.right * speed;
		}
		if (Input.GetKey (KeyCode.D)) 
		{
			transform.position += transform.right * speed;
		}

        // Subida y Bajada del Elevador
		if (transform.parent == ev && Input.GetKeyDown(KeyCode.S) && Elevador.pisos > 0 && !inMovement) 
		{
            desp = -0.1f;
			StartCoroutine ("Desplazamiento");
            Elevador.pisos--;
            print(Elevador.pisos);
        }
        if (transform.parent == ev && Input.GetKeyDown(KeyCode.W) && Elevador.pisos < 15 && !inMovement) 
		{
            desp = 0.1f;
			StartCoroutine ("Desplazamiento");
            Elevador.pisos++;
            print(Elevador.pisos);
        }
    }

    //Corutina para el dezplazamiento del Ascensor
    public IEnumerator Desplazamiento()
    {
        inMovement = true;
        for (int i = 0; i < 50; i++)
        {
            Transition();
            yield return new WaitForSeconds(0.01f);
        }
        inMovement = false;

    }

    // Cantidad de Transición durante cada repetición de la Corrutina
    public void Transition()
    {
        ev.transform.position += new Vector3(0, desp, 0);
    }

}
