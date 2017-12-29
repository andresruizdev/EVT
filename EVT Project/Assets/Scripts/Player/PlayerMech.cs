using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class PlayerMech : MonoBehaviour {
    public static Color[] colorBag = new Color[2];
    public static int bagPosition = 0;
    public GameObject bagColor, bagColor1;

	void Start()
	{
        SetColorPower();
    }

    private void Update()
    {
        BagColorsUI1();
        BagColorsUI2();
        BagControls();
    }

    //Asigna el color que hay en la posicion principal de la mochila al piso
    void OnTriggerStay(Collider other)
	{
		if (other.tag == "Piso" && Input.GetKey(KeyCode.Space)) 
		{
			other.GetComponent<Renderer> ().material.color = colorBag[bagPosition];
		}
	}

    void SetColorPower()
    {// De manera Aleatoria, selecciona los colores que van a aparecer en el principio
        int colorPackage = Random.Range(0,3);
        if (colorPackage == 0)
        {
            colorBag[0] = Color.red;
            colorBag[1] = Color.cyan;
        }
        else if (colorPackage == 1)
        {
            colorBag[0] = Color.red;
            colorBag[1] = Color.magenta;
        }
        else if (colorPackage == 2)
        {
            colorBag[0] = Color.yellow;
            colorBag[1] = Color.cyan;
        }
        else if (colorPackage == 3)
        {
            colorBag[0] = Color.yellow;
            colorBag[1] = Color.magenta;
        }
    }

    void BagColorsUI1()
    { // Cambia el color del icono que refloja el color principal que hay en la mochila
        if (colorBag[0] == Color.blue)
        {
            bagColor.GetComponent<Image>().color = Color.blue;
        }
        else if (colorBag[0] == Color.red)
        {
            bagColor.GetComponent<Image>().color = Color.red;
        }
        else if (colorBag[0] == Color.yellow)
        {
            bagColor.GetComponent<Image>().color = Color.yellow;
        }
        else if (colorBag[0] == Color.cyan)
        {
            bagColor.GetComponent<Image>().color = Color.cyan;
        }
        else if (colorBag[0] == Color.magenta)
        {
            bagColor.GetComponent<Image>().color = Color.magenta;
        }
    }

    void BagColorsUI2()
    {// Cambia el color del icono que refleja el color secundario que hay en la mochila
        if (colorBag[1] == Color.blue)
        {
            bagColor1.GetComponent<Image>().color = Color.blue;
        }
        else if (colorBag[1] == Color.red)
        {
            bagColor1.GetComponent<Image>().color = Color.red;
        }
        else if (colorBag[1] == Color.yellow)
        {
            bagColor1.GetComponent<Image>().color = Color.yellow;
        }
        else if (colorBag[1] == Color.cyan)
        {
            bagColor1.GetComponent<Image>().color = Color.cyan;
        }
        else if (colorBag[1] == Color.magenta)
        {
            bagColor1.GetComponent<Image>().color = Color.magenta;
        }
    }

    void ChangingColor() // Contiene la funcion para cambiar el color primario por el secundaro y viceversa
    {
        GameObject auxG = bagColor;
        bagColor = bagColor1;
        bagColor1 = auxG;
    }

    void BagControls() // Contiene los controles para cambiar los colores en las casillas de la mochila 
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && bagPosition == 0)
        {
            bagPosition++;
            ChangingColor();
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift) && bagPosition == 1)
        {
            bagPosition--;
            ChangingColor();
        }
    }
}
