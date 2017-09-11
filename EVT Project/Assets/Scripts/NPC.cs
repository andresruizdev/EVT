using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour {
    public int typeSelector;
    struct NPCStruct
    {
        public int healt;
        public float speed;
    }

    enum NPCType
    {
        enemy1,
        enemy2,
        boy,
        girl
    }

    public void Start()
    {

        typeSelector = Random.Range(0,5);
        NPCType npcType = new NPCType();
        NPCStruct npcChar = new NPCStruct();
        switch (typeSelector)
        {
            case 1:
                npcType = NPCType.enemy1;
                break;
            case 2:
                npcType = NPCType.enemy2;
                break;
            case 3:
                npcType = NPCType.boy;
                break;
            case 4:
                npcType = NPCType.girl;
                break;
        }

        if (npcType == NPCType.enemy1)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            npcChar.healt = 150;
        }
        if (npcType == NPCType.enemy2)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            npcChar.healt = 120;
        }
        if (npcType == NPCType.girl)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            npcChar.healt = 90;
        }
        if (npcType == NPCType.boy)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            npcChar.healt = 100;
        }
        print("Type: " + npcType);
        print("Health: " + npcChar.healt);
    }
}
