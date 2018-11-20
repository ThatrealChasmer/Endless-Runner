using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanSpawn : MonoBehaviour {

    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 1 - transform.localScale.y)
        {
            transform.parent.gameObject.GetComponent<SpawnWall>().canSpawn = true;
            Destroy(this);
        }
    }
}
