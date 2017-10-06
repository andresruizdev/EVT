using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class TutorialManager : MonoBehaviour {
    [SerializeField] GameObject[] tutorial = new GameObject[7];
    int[] control = new int[7];
    bool other;
    string code;
	void Start ()
    {
        for (int i = 0; i < control.Length; i++)
        {
            control[i] = 0;
        } // Ciclo que coloca el vector de la variable de control en 0;
        Invoke("DesplazarIzq", 1f);
        code = "A";
        other = true;
	}

    // Aqui se definen cada uno de los metodos que activaran el texto instructivo para diferente caso
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
        KeyVerification(); // Verificacion de la tecla que se presiona
    }

    void KeyVerification()
    {
        // Para cada uno de los casos si la tecla es presionada y el texto en pantalla corresponde a ella, se ejecuta
        if (Input.GetKey(KeyCode.A) && code == "A") 
        {
            other = false;
            tutorial[0].SetActive(false);
            if (control[0] < 1 && other != true)
            {
                // Aqui se genera otro texto despues de 3 segundos y pone bloqueos para que el usuario no pueda desactivar con otra tecla
                Invoke("DesplazarDer", 3f);
                other = true;
                code = "D";
                control[0]++;
            }
            
        }
        if (Input.GetKey(KeyCode.D) && code == "D")
        {
            other = false;
            tutorial[1].SetActive(false);
            if (control[1] < 1 && other != true)
            {
                Invoke("GirarDer", 3f);
                other = true;
                control[1]++;
                code = "E";
            }
            
        }
        if (Input.GetKey(KeyCode.E) && code == "E")
        {
            other = false;
            tutorial[2].SetActive(false);
            if (control[2] < 1 && other != true)
            {
                Invoke("GirarIzq", 1f);
                other = true;
                control[2]++;
                code = "Q";
            }
        }

        if (Input.GetKey(KeyCode.Q) && code == "Q")
        {
            other = false;
            tutorial[3].SetActive(false);
            if (control[3] < 1 && other != true)
            {
                Invoke("GirarCamIzq", 3f);
                other = true;
                control[3]++;
                code = "LeftArrow";
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow) && code == "LeftArrow")
        {
            other = false;
            tutorial[4].SetActive(false);
            if (control[4] < 1 && other != true)
            {
                Invoke("GirarCamDer", 4f);
                other = true;
                control[4]++;
                code = "RightArrow";
            }
        }
        if (Input.GetKey(KeyCode.RightArrow) && code == "RightArrow")
        {
            other = false;
            tutorial[5].SetActive(false);
            if (control[5] < 1 && other != true)
            {
                Invoke("ElevatorMovement", 4f);
                other = true;
                control[5]++;
                code = "UpDownArrow";
            }
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow) && code == "UpDownArrow")
        {
            other = false;
            if (control[6] < 1 && other != true)
            {
                tutorial[6].SetActive(false);
                other = true;
                control[6]++;
            }
        }
    }
}
