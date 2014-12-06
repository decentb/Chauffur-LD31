using UnityEngine;
using System.Collections;

public class SpawnRoadStripes : MonoBehaviour {

    public float timeBetweenStripes = 1.0f;
    public float stripeSpeed = 1.0f;
    public Transform roadStripePrefab;
    public Transform cleanupObject;

	// Use this for initialization
	void Start()
    {
        StartCoroutine(SpawnStripes());
	}

    IEnumerator SpawnStripes()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBetweenStripes);
            Transform roadStripe = (Transform)Instantiate(roadStripePrefab, this.transform.position, Quaternion.identity);
            roadStripe.name = "Road Stripe";
            roadStripe.rigidbody2D.velocity = new Vector2(0, stripeSpeed);
            RoadStripe stripeScript = roadStripe.GetComponent<RoadStripe>();
            stripeScript.cleanupObject = cleanupObject;
        }
    }
	
	// Update is called once per frame
	void Update()
    {
	
	}
}
