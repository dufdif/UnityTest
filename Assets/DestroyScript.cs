using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {

    public string TAG;
	void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TAG))
            Destroy(other.gameObject);


    }
}
