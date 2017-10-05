using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonTargetMovement : MonoBehaviour {
    int nextTarget;
    void Start()
    {
        CondicionalTarget(); // Se llama el metodo que se explica a continuacion
    }
    //Se Definen las coordenadas para los NPC (En total son 5 Puntos predeterminados que van cambiando que se veran reflejados en los siguientes metodos)
    void RightMovement()
    {
        nextTarget = Random.Range(0, 1);
        transform.position = new Vector3(20, 80, 16);
        Invoke("Esquina1", 5f);
    }

    void DiagonalMovement()
    {
        nextTarget = Random.Range(0, 1);
        transform.position = new Vector3(1.8f, 80, 40);
        Invoke("Esquina2", 5f);
    }

    void LeftMovement()
    {
        nextTarget = Random.Range(0, 1);
        transform.position = new Vector3(-20, 80, 16);
        Invoke("DiagonalMovement", 15f);
    }

    void Esquina1()
    {
        nextTarget = Random.Range(0, 1);
        transform.position = new Vector3(-17, 80, 16);
        Invoke("LeftMovement", 5f);
    }

    void Esquina2()
    {
        nextTarget = Random.Range(0, 1);
        transform.position = new Vector3(15, 80, 16);
        Invoke("RightMovement", 5f);
    }

    void CondicionalTarget()
    { // Se tiene esta condicional para seleccionar entre distintos puntos de seguimiento para los NPC
        if (gameObject.tag == "Target")
        {
            Invoke("LeftMovement", 1f);
        }
        else if (gameObject.tag == "Target1")
        {
            Invoke("RightMovement", 0.1f);
        }
        else if (gameObject.tag == "Target2")
        {
            Invoke("Esquina1", 2f);
        }
        else if (gameObject.tag == "Target3")
        {
            Invoke("Esquina2", 3f);
        }
    }
}
