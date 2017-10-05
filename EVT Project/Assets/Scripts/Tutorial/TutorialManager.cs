using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour {
    [SerializeField] GameObject[] tutorial = new GameObject[7];
	void Start ()
    {
        Invoke("DesplazarIzq", 1f);
	}
    void DesplazarIzq()
    {
        tutorial[0].SetActive(true);
	}

    void DesplazarDer()
    {
        tutorial[1].SetActive(true);
    }

    void GirarDer()
    {
        tutorial[2].SetActive(true);
    }

    void GirarIzq()
    {
        tutorial[3].SetActive(true);
    }

    void GirarCamIzq()
    {
        tutorial[4].SetActive(true);
    }

    void GirarCamDer()
    {
        tutorial[5].SetActive(true);
    }

    void ElevatorMovement()
    {
        tutorial[6].SetActive(true);
    }

    void Update()
    {
        KeyVerification();
    }

    void KeyVerification()
    {
        if (Input.GetKey(KeyCode.A))
        {
            tutorial[0].SetActive(false);
            Invoke("DesplazarDer", 3f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            tutorial[1].SetActive(false);
            Invoke("GirarDer", 3f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            tutorial[2].SetActive(false);
            Invoke("GirarIzq", 1f);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            tutorial[3].SetActive(false);
            Invoke("GirarCamIzq", 3f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tutorial[4].SetActive(false);
            Invoke("GirarCamDer", 4f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tutorial[5].SetActive(false);
            Invoke("ElevatorMovement", 4f);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            tutorial[6].SetActive(false);
        }
    }
}
