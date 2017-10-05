using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButtons : MonoBehaviour {
    // Cambia de Color en la Posición de la mochila de colores en la que esté en el momento tras ser llamada esta función mediante el botón correspondiente
    // Puede ser seleccionado el azul, cyan, amarillo, magenta y rojo
    public void SetBlue()
    {
        PlayerMech.colorBag[PlayerMech.bagPosition] = Color.blue; 
    }

    public void SetRed()
    {
        PlayerMech.colorBag[PlayerMech.bagPosition] = Color.red;
    }

    public void SetYellow()
    {
        PlayerMech.colorBag[PlayerMech.bagPosition] = Color.yellow;
    }

    public void SetCyan()
    {
        PlayerMech.colorBag[PlayerMech.bagPosition] = Color.cyan;
    }

    public void SetMagenta()
    {
        PlayerMech.colorBag[PlayerMech.bagPosition] = Color.magenta;
    }
}
