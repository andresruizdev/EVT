using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMech : MonoBehaviour {
    Color[] colorBag = new Color[2];

	void Start()
	{
        SetColorPower();
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
}
