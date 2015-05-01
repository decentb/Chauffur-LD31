using UnityEngine;
using System.Collections;

public class CatCarMovement : MonoBehaviour {

    float axisX = 0;

    public float horizontalSpeed = 1.0f;
    public Transform catPaw;
    public Transform carDoor;

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
        GetComponent<Rigidbody2D>().velocity = new Vector2(axisX * horizontalSpeed, 0);

        if (GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            catPaw.gameObject.SetActive(true);
            carDoor.gameObject.SetActive(false);
        }
        else
        {
            catPaw.gameObject.SetActive(false);
            carDoor.gameObject.SetActive(true);
        }
    }
}
