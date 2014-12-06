using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InputManager : MonoBehaviour {

    // Editor fields
    public Transform catCar;
    public float mouseSensitivity = 1.0f;
    public float tiltSensitivity = 1.0f;
    public float deadZone = 0.2f;

    EventManager eventManager;
    CatCarMovement catCarMovementScript;

    float axisX = 0;

	// Use this for initialization
	void Start()
    {
        eventManager = GetComponent<EventManager>();
        catCarMovementScript = catCar.GetComponent<CatCarMovement>();
	}
	
	// Update is called once per frame
	void Update()
    {
        if (Input.mousePresent)
        {
            // Use the mouse position to determine the X axis
            float mousePosition = Input.mousePosition.x;
            axisX = mousePosition * mouseSensitivity / (Screen.width / 2);
        }
        else
        {
            // If no mouse is present, then this is probably a mobile device
            // Grab X axis from accelerometer
            axisX = Input.acceleration.x * tiltSensitivity;
        }

        if (axisX > deadZone || axisX < -deadZone)
        {
            catCarMovementScript.SetNewAxisX(axisX);
        }
        else
        {
            catCarMovementScript.SetNewAxisX(0);
        }

	    if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("[KEY] Escape");
            eventManager.SendMessage("OnHitEscape");
        }
	}
}
