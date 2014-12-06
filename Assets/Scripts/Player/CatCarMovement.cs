using UnityEngine;
using System.Collections;

public class CatCarMovement : MonoBehaviour {

    float axisX = 0;

    public float horizontalSpeed = 1.0f;

    // Use this for initialization
    void Start()
    {
    }

    public void SetNewAxisX(float newAxisX)
    {
        axisX = newAxisX;
    }
	
	// Update is called once per frame
	void Update()
    {
        Debug.Log("Horizontal Velocity = " + axisX * horizontalSpeed);
        rigidbody2D.velocity = new Vector2(axisX * horizontalSpeed, 0);
    }
}
