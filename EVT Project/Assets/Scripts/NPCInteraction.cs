using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "NPC" && GetComponent<Renderer>().material.color == other.GetComponent<Renderer>().material.color)
        {
            other.gameObject.transform.localScale -= new Vector3(0, .3f, 0);
            Vector3 die = new Vector3(1,0,1);
            if (other.transform.localScale.y < 0)
            {
                other.gameObject.SetActive(false);
                NPCNavMesh.npcNumbers--;
            }
        }

        if ((other.tag == "Girl" || other.tag == "Boy" || other.tag == "ConvertedNPC") && GetComponent<Renderer>().material.color == other.GetComponent<Renderer>().material.color)
        {
            other.GetComponent<Renderer>().material.color = Color.green;
            other.gameObject.tag = "SavedNPC";
        }
    }
    
}
