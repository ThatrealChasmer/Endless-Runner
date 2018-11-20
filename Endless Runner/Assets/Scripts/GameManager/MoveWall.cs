using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour {

    public Vector3 startPosition;
    public Vector3 endPosition;

    public float speed;
    private float startTime;

    private float journeyLength;

    // Use this for initialization
    void Start()
    {
        startPosition = transform.position;
        endPosition = new Vector3(-startPosition.x, startPosition.y, startPosition.z);
        startTime = Time.time;
        journeyLength = Vector3.Distance(startPosition, endPosition);
    }

    // Update is called once per frame
    void Update()
    {

        float distCovered = (Time.time - startTime) * speed;

        float fracJourney = distCovered / journeyLength;

        transform.position = Vector3.Lerp(startPosition, endPosition, fracJourney);

        if (transform.position.x == endPosition.x)
        {
            Debug.Log(Time.timeScale);
            Destroy(gameObject);
        }

        if (Time.timeScale <= 5f)
        {
            Time.timeScale = Time.timeScale + 0.0001f;
        }

    }

}
