using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWall : MonoBehaviour {

    public GameObject wallPrefab;
    public bool canSpawn = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (canSpawn == true)
        {
            float r = Random.Range(1, 4);
            Instantiate(wallPrefab, new Vector3(11, r / 2, 0), Quaternion.identity, transform);
            canSpawn = false;
        }
	}
}
