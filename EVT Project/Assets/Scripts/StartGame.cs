using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {
    public Transform theCamera;

    void LateUpdate()// Realiza movimiento rotatorio en el Menu principal
    {
        theCamera.transform.eulerAngles += new Vector3(0f, -0.5f, 0f);
    }
}
