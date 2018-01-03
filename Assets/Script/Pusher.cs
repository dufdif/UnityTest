using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour {

    Vector3 StartPos;
    public float moveVal;//움직인량
    public float speed;//이동속력

	// Use this for initialization
	void Start () {
        StartPos = transform.localPosition;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float z = moveVal * Mathf.Sin(speed * Time.time);
        transform.localPosition = StartPos + new Vector3(0, 0, z);
		
	}
}
