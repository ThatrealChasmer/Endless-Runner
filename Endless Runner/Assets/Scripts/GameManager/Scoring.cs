using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x <= -4)
        {
            transform.parent.gameObject.GetComponent<UIHandler>().score += 1;
            Destroy(this);
        }
	}
}
