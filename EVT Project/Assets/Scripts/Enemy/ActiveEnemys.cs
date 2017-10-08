using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class ActiveEnemys : MonoBehaviour {
    public GameObject[] npc = new GameObject[7];
	// Use this for initialization
	void Start ()
    {
        Invoke("Active", 2f);	
	}
	
    void Active()
    {
        for (int i = 0; i < npc.Length; i++)
        {
            npc[i].gameObject.SetActive(true);
        }
    }
}
