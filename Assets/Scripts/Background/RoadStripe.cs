using UnityEngine;
using System.Collections;

public class RoadStripe : MonoBehaviour {

    public Transform cleanupObject;

	// Use this for initialization
	void Start()
    {
	}
	
	// Update is called once per frame
	void Update()
    {
        // Cleanup stripe
        if (transform.position.z < cleanupObject.position.z)
        {
            Destroy(this.gameObject);
        }
	}
}
