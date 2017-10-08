using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Info : MonoBehaviour {
    [SerializeField] GameObject infoPanel;

	void Start ()
    {
        Invoke("ActivePanel", 1f);
	}

    void ActivePanel()
    {
        infoPanel.SetActive(true);
    }
	
}
