using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {// Esto hará que los enemigos mueran cuando el personaje pone el piso del mismo color que ellos
        if (other.tag == "NPC" && GetComponent<Renderer>().material.color == other.GetComponent<Renderer>().material.color)
        {
            other.gameObject.transform.localScale -= new Vector3(0, .3f, 0);
            Vector3 die = new Vector3(1,0,1);
            if (other.transform.localScale.y < 0)
            {
                other.gameObject.SetActive(false);
                NPCNavMesh.npcNumbers--; // Se disminuye el número de NPC que infuirá al final para poder ganar
            }
        }
        //Este condicional permite que se salven los ciudadanos cuando el personaje pone el piso del mismo color que ellos
        if ((other.tag == "Girl" || other.tag == "Boy" || other.tag == "ConvertedNPC") && GetComponent<Renderer>().material.color == other.GetComponent<Renderer>().material.color)
        {
            other.GetComponent<Renderer>().material.color = Color.green;
            other.gameObject.tag = "SavedNPC";
        }
    }
    
}
