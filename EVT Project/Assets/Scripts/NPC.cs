using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int typeSelector;
    public int enemyConverter;
    [SerializeField] GameObject particle;

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
                enemyConverter = Random.Range(25, 150);
                break;
            case 3:
                npcType = NPCType.girl;
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
                gameObject.tag = "Girl";
                enemyConverter = Random.Range(20, 130);
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC" && (gameObject.tag == "Boy" || gameObject.tag == "Girl"))
        {
            enemyConverter--;
            //print(gameObject.name + ": " + enemyConverter);
            // Hacer que los Enemigos puedan convertir a los Ciudadanos en enemigos
            if (enemyConverter <= 0)
            {
                gameObject.tag = "ConvertedNPC";
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
        }
    }
}
