using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class BotiquinMovement : MonoBehaviour {
    BotiquinStats botiquinStats = new BotiquinStats();
    int despControl;
	void Update()
    {
        StartCoroutine("Movement"); // Se inicia desde que se cambia de escena el movimiento del botiquin
	}

    IEnumerator Movement()
    {
        transform.Rotate(new Vector3(0, botiquinStats.speed, 0));  // Corrutina con el movimiento del botiquin (Solo rotacion)      
        yield return null;
    }
}
public sealed class BotiquinStats : Stats
{
    public BotiquinStats()
    {
        desp = 0.01f;
    }
}
