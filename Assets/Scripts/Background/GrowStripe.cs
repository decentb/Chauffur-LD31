using UnityEngine;
using System.Collections;

public class GrowStripe : MonoBehaviour {

    public float scaleIncrease = 0.01f;
    public float timeBetweenScale = 1.0f;

	// Use this for initialization
	void Start()
    {
        StartCoroutine(ScaleIncrease(scaleIncrease, timeBetweenScale));
	}

    IEnumerator ScaleIncrease(float sizeIncrease, float timeBetweenScale)
    {
        while(true)
        {
            yield return new WaitForSeconds(timeBetweenScale);
            transform.localScale *= scaleIncrease;
        }
    }
	
	// Update is called once per frame
	void Update()
    {
	    
	}
}
