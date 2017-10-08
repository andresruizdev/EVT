using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class BotiquinMovement : MonoBehaviour {
    BotiquinStats botiquinStats = new BotiquinStats();
    int despControl;
	void Update()
    {
        StartCoroutine("Movement");
	}

    IEnumerator Movement()
    {
        transform.Rotate(new Vector3(0, botiquinStats.speed, 0));        
        yield return null;
    }
}
public sealed class BotiquinStats : Stats
{
    public BotiquinStats()
    {
        speed = 2f;
        desp = 0.01f;
    }
}
