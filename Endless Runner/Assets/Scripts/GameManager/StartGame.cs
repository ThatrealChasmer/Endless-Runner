using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

    public GameObject playerPrefab;
	// Use this for initialization
	void Start () {
        Instantiate(playerPrefab, new Vector3(-4, -4, 0), Quaternion.identity);
	}
}
