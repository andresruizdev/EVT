using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMech : MonoBehaviour {
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
        
        print(colorBag[0]);
        print(colorBag[1]);
        if (Input.GetKeyDown(KeyCode.LeftAlt) && bagPosition == 0)
        {
            bagPosition++;
            ChangingColor();
        }
        else if (Input.GetKeyDown(KeyCode.LeftAlt) && bagPosition == 1)
        {
            bagPosition--;
            ChangingColor();
        }
    }
    void OnTriggerStay(Collider other)
	{
		if (other.tag == "Piso" && Input.GetKey(KeyCode.Space)) 
		{
			other.GetComponent<Renderer> ().material.color = colorBag[0];
		}
	}

    void SetColorPower()
    {
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
        print("Color 1: " + colorBag[0]);
        print("Color 2:" + colorBag[1]);
    }

    void BagColorsUI1()
    {
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
    {
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

    void ChangingColor()
    {
        Color aux = colorBag[0];
        colorBag[0] = colorBag[1];
        colorBag[1] = aux;
    }
}
