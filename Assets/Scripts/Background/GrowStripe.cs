using UnityEngine;
using System.Collections;

public class GrowStripe : MonoBehaviour {

    public float xScaleIncrease = 1.01f;
    public float yScaleIncrease = 1.01f;
    public float timeBetweenScale = 1.0f;

	// Use this for initialization
	void Start()
    {
        StartCoroutine(ScaleIncrease());
	}

    IEnumerator ScaleIncrease()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBetweenScale);
            transform.localScale = new Vector3(transform.localScale.x * xScaleIncrease, transform.localScale.y * yScaleIncrease, transform.localScale.z);
        }
    }
	
	// Update is called once per frame
	void Update()
    {
	    
	}
}
