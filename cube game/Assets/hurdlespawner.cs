using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurdlespawner : MonoBehaviour {
    public Transform[] spawnplaces;
    public GameObject hurdleprefab;
	void Start () 
    {
        int randomindex = Random.Range(0, spawnplaces.Length);
        for (int i = 0; i < spawnplaces.Length; i++)
        {
            if (randomindex != i)
            {
                Instantiate(hurdleprefab, spawnplaces[i].position,Quaternion.identity);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
