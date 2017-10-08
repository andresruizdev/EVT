using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public sealed class PlayerStats : MonoBehaviour
{
    PlayerStatsValues playerStats = new PlayerStatsValues();
    public GameObject loser;
    public Slider healthSlider;


    void Start()
    {
        playerStats.currentHealth = playerStats.health;
        healthSlider.value = playerStats.currentHealth;
    }

    void OnTriggerEnter(Collider other)
    {
        //Disminuye una cantidad de sangre cada que el personaje choca contra un enemigo
        if (other.tag == "NPC" || other.tag == "ConvertedNPC")
        {
            playerStats.currentHealth -= 2f;
            healthSlider.value = playerStats.currentHealth;
            if (playerStats.currentHealth == 0)
            {
                loser.SetActive(true); // si la sangre está en 0, se muestra pantalla de perdida
            }
        }

        else if (other.tag == "botiquin")
        {
            int cantidadSalud = Random.Range(1, 3);
            if (cantidadSalud == 1)
            {
                playerStats.currentHealth += 10;
                MaxLimit();
                print(playerStats.currentHealth);
            }
            else if (cantidadSalud == 2)
            {
                playerStats.currentHealth += 5;
                MaxLimit();
                print(playerStats.currentHealth);
            }
            else if (cantidadSalud == 3)
            {
                playerStats.currentHealth += 2;
                MaxLimit();
                print(playerStats.currentHealth);
            }
            Destroy(other.gameObject);
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

    public void MaxLimit()
    {
        if (playerStats.currentHealth > 100)
        {
            playerStats.currentHealth = 100;
            print(playerStats.currentHealth);
        }
    }
}

public sealed class PlayerStatsValues : Stats // Se hereda de la clase Stats para crear la salud del personaje
{
    public PlayerStatsValues() // Se crea Constructor donde se asigna a la variable health el valor de 100
    {
        health = 100; 
    }
}
