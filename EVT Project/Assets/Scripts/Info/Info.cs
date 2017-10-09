using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Info : MonoBehaviour {
    [SerializeField] GameObject infoPanel;

	void Start ()
    {
        Invoke("ActivePanel", 1f); // Se activa el panel a un segundo de iniciar el juego
	}

    void ActivePanel()// Activa panel de informacion (Controles e Instrucciones)
    {
        infoPanel.SetActive(true);
    }
	
}
