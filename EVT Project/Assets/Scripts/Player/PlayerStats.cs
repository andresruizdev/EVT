using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public GameObject loser;
    public float health = 100, currentHealth;
    public Slider healthSlider;


    void Start()
    {
        currentHealth = health;
        healthSlider.value = currentHealth;
    }

    void OnTriggerEnter(Collider other)
    {
        //Disminuye una cantidad de sangre cada que el personaje choca contra un enemigo
        if (other.tag == "NPC" || other.tag == "ConvertedNPC")
        {
            currentHealth-= 2f;
            healthSlider.value = currentHealth;
            if (currentHealth == 0)
            {
                loser.SetActive(true); // si la sangre está en 0, se muestra pantalla de perdida
            }
        }        
    }
    public void ResetScene()
    {
        SceneManager.LoadScene(1); // Reinicia la Escena
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);// Se regresa al menu principal
    }

}
