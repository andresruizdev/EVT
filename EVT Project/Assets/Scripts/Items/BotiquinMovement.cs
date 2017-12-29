using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class BotiquinMovement : MonoBehaviour {
	void Update()
    {
        transform.Rotate(new Vector3(0f, 2f, 0f)); // Rotación Botiquin
    }
    
}
