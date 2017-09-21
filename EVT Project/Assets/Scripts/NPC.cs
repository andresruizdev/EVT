using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int typeSelector;
    struct NPCStruct
    {
        int healt;
        float speed;
    }

    public enum NPCType
    {
        enemy1,
        enemy2,
        boy,
        girl
    }

    public void Start()
    {
        Selector();
    }

    void Selector()
    {
        typeSelector = Random.Range(0, 4);
        NPCType npcType = new NPCType();
        switch (typeSelector)
        {
            case 0:
                npcType = NPCType.enemy1;
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 1:
                npcType = NPCType.enemy2;
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case 2:
                npcType = NPCType.boy;
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
                gameObject.tag = "Boy";
                break;
            case 3:
                npcType = NPCType.girl;
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
                gameObject.tag = "Girl";
                break;
        }
    }

    void VerifySalvation()
    {
        if ((gameObject.tag == "Boy" || gameObject.tag == "Girl") && GetComponent<Renderer>().material.color == Color.green)
        {
            
        }
    }
}
