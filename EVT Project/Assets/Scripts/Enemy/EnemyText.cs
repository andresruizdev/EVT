using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class EnemyText : MonoBehaviour {
    [SerializeField] Text[] enemyText = new Text[3];
    public static int[] enemyCounter = new int[3];
    
	//Actualiza cantidad de enemgios
	void Update ()
    {
        enemyText[0].text = enemyCounter[0].ToString();
        enemyText[1].text = enemyCounter[1].ToString();
        enemyText[2].text = enemyCounter[2].ToString();
    }
}
