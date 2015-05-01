using UnityEngine;
using System.Collections;

public class SpawnRoadStripes : MonoBehaviour {

    public float timeBetweenStripes = 1.0f;
    public float stripeSpeed = 1.0f;
    public Transform roadStripePrefab;

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
            roadStripe.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, stripeSpeed);
            roadStripe.transform.parent = transform;
            RoadStripe stripeScript = roadStripe.GetComponent<RoadStripe>();
        }
    }
	
	// Update is called once per frame
	void Update()
    {
	}
}
