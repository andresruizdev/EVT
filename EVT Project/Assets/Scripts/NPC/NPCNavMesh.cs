using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public sealed class NPCNavMesh : MonoBehaviour {

    [SerializeField] Transform target, nonTarget, cTarget1, cTarget2, cTarget3, cTarget4, player;
    [SerializeField] NavMeshAgent npc;
    [SerializeField] float updateDelay = .3f;
    [SerializeField] GameObject messagePanel;
    [SerializeField] Text messageText, Type;
    public static int npcNumbers = 48;

    void Reset()
    {
        npc = GetComponent<NavMeshAgent>(); // Reinicia a los valores por defecto
    }

    void Update()
    {
        ColorVerification();   //Verificación del color del ciudadano
    }
    void Start()
    {
        SetTarget();// Llamada al metodo de seleccion de objetivo
        InvokeRepeating("FollowTarget",0f, updateDelay);
    }

    void FollowTarget()
    {
        npc.SetDestination(target.position); // Hace que los NPC sigan al objetivo ya establecido por medio de NAV Mesh
    }

    void OnTriggerEnter(Collider other)
    {
        //Cambia objetivo y selecciona el tipo de mensaje del npc
        if (other.tag == "Player" && (gameObject.tag == "NPC" || gameObject.tag == "ConvertedNPC"))
        {
            target = other.transform;
            //Selecciona uno entre varias posibilidades de mensaje
            int possibilities = Random.Range(0, 2);
            if (possibilities == 0)
            {
                Type.text = "Enemigo";
                messageText.text = "Grrr... Rarrr...";
            }
            else if (possibilities == 1)
            {
                Type.text = "Enemigo";
                messageText.text = "Rada... Radaaaa";
            }
            else if (possibilities == 2)
            {
                Type.text = "Enemigo";
                messageText.text = "Ñommm... Ñomm...";
            }
            messagePanel.SetActive(true);
        }
        //Selecciona el tipo de mensaje del npc
        if (other.tag == "Player" && gameObject.tag == "Boy")
        {
            int possibilities = Random.Range(0, 2);
            //Selecciona uno entre varias posibilidades de mensaje
            if (possibilities == 0)
            {
                Type.text = "Ciudadano";
                messageText.text = "Hola, Soy Camilo";
            }
            else if (possibilities == 1)
            {
                Type.text = "Ciudadano";
                messageText.text = "Hola, Soy Andres";
            }
            else if (possibilities == 2)
            {
                Type.text = "Ciudadano";
                messageText.text = "Hola, Soy Santiago";
            }
            messagePanel.SetActive(true);
        }
        //Selecciona el tipo de mensaje del npc
        if (other.tag == "Player" && gameObject.tag == "Girl")
        {
            int possibilities = Random.Range(0, 2);
            //Selecciona uno entre varias posibilidades de mensaje
            if (possibilities == 0)
            {
                Type.text = "Ciudadana";
                messageText.text = "Hola, Soy Valentina";
            }
            else if (possibilities == 1)
            {
                Type.text = "Ciudadana";
                messageText.text = "Hola, Soy Camila";
            }
            else if (possibilities == 2)
            {
                Type.text = "Ciudadana";
                messageText.text = "Hola, Soy Karina";
            }
        }
    }

    void OnTriggerExit(Collider other)
    {//Desactiva el mensaje y cambia nuevamente el objetivo a otro diferente del jugador
        if (other.tag == "Player")
        {
            SetTarget();
            messagePanel.SetActive(false);
        }
    }

    void SetTarget()// El metodo que hace que se pueda cambiar de objetivos
    {
        if (gameObject.tag == "Boy" || gameObject.tag == "Girl")
        {
            int number = Random.Range(0,1);
            if (number == 0)
            {
                target = cTarget1;
            }
            else if (number == 1)
            {
                target = cTarget3;
            }
        }

        if (gameObject.tag == "NPC")
        {
            int num = Random.Range(0,1);
            if (num == 0)
            {
                target = cTarget2;
            }
            else if (num == 1)
            {
                target = cTarget4;
            }
        }
    }

    void ColorVerification()
    {// Verifica si el Ciudadano ya ha sido salvado y lo hace mas pequeño para despues desaparecer
        if (GetComponent<Renderer>().material.color == Color.green)
        {
            target = player;
            LessScale();
        }
    }

    void LessScale()
    {
        // Esto es lo que permite que el Ciudadano salvado se encoja y posteriormente tras 2 segundos se desactive
        gameObject.transform.localScale -= new Vector3(.006f, .006f, .006f);
        Invoke("Deactive", 2f);
    }

    void Deactive()
    {// Es llamado en LessScale para desactivar objetos
        gameObject.SetActive(false);
        npcNumbers--;
    }


}
