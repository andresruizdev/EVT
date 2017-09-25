using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public float health = 100, currentHealth;
    public Slider healthSlider;


    void Start()
    {
        currentHealth = health;
        healthSlider.value = currentHealth;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC" || other.tag == "ConvertedNPC")
        {
            currentHealth-= .2f;
            healthSlider.value = currentHealth;
            if (currentHealth == 0)
            {
                print("GameObject");
            }
        }
        
    }

}
