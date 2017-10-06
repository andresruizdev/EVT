using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PlayerMovement : MonoBehaviour
{
    public Transform ev;
    public float desp = 0;
	public bool inMovement;
	public Rigidbody rb;
    public GameObject win;
    PlayerSpeedFromStats playerSpeed = new PlayerSpeedFromStats();

	void Start()
	{
		rb.GetComponent<Rigidbody>();
        print(playerSpeed.speed);
	}
	void Update () 
	{
        PlayerMovementControls();
        ElevatorMovement();
    }

	//Corrutina para el dezplazamiento del Ascensor
	public IEnumerator Desplazamiento()
	{
		inMovement = true;
		for (int i = 0; i < 50; i++) 
		{
			Transition ();
			yield return new WaitForSeconds (0.01f);
		}
		inMovement = false;

	}

    //Corutina para la rotacion del personaje
	public IEnumerator Rotation()
	{
		inMovement = true;
		for (int i = 0; i < 90; i++) 
		{
			Rotate();
			yield return new WaitForSeconds (0.01f);
		}
        inMovement = false;
        print("Entrando");

	}

	// Cantidad de Transición durante cada repetición de la Corrutina
	public void Transition()
	{
		ev.transform.position += new Vector3(0, desp, 0);
	}

    // Cantidad de rotacion por cada repeticion de la Corrutina
	void Rotate()
	{
		transform.eulerAngles += new Vector3(0f,desp*2,0f);
	}

    void PlayerMovementControls()
    {
        //Movimiento de Izquierda a Derecha
        if (Input.GetKey(KeyCode.A) && !inMovement)
        {
            rb.MovePosition(transform.position - transform.right * playerSpeed.speed);
        }
        if (Input.GetKey(KeyCode.D) && !inMovement)
        {
            rb.MovePosition(transform.position + transform.right * playerSpeed.speed);
        }

        // Movimiento de rotacion
        if (Input.GetKeyDown(KeyCode.Q) && !inMovement)
        {
            desp = 0.5f;
            StartCoroutine("Rotation");
        }
        if (Input.GetKeyDown(KeyCode.E) && !inMovement)
        {
            desp = -0.5f;
            StartCoroutine("Rotation");
        }
    }

    void ElevatorMovement()
    {
        // Subida y bajada del Ascensor
        if (transform.parent == ev && Input.GetKeyDown(KeyCode.DownArrow) && !inMovement && Elevador.pisos > 0)
        {
            Elevador.pisos--;
            print(Elevador.pisos);
            desp = -0.1f;
            StartCoroutine("Desplazamiento");
            if (Elevador.pisos == 0 && NPCNavMesh.npcNumbers == 0)
            {
                inMovement = true;
                win.SetActive(true);
            }
        }
        if (transform.parent == ev && Input.GetKeyDown(KeyCode.UpArrow) && !inMovement && Elevador.pisos < 15)
        {
            Elevador.pisos++;
            print(Elevador.pisos);
            desp = 0.1f;
            StartCoroutine("Desplazamiento");
        }
    }

}

public sealed class PlayerSpeedFromStats : Stats
{
    public PlayerSpeedFromStats()
    {
        speed = 0.2f;
    }
}
