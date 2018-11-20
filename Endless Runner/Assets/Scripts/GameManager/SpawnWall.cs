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
            int r = Random.Range(1, 5);
            float f = r;
            Debug.Log(r);
            GameObject wall = Instantiate(wallPrefab, new Vector3(11, f / 2 - 4.5f, 0), Quaternion.identity, transform);
            wall.transform.localScale = new Vector3(1, r, 1);

            canSpawn = false;
        }
	}
}
