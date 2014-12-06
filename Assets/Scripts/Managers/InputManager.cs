using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InputManager : MonoBehaviour {

    EventManager eventManager;

	// Use this for initialization
	void Start()
    {
        eventManager = GetComponent<EventManager>();
	}
	
	// Update is called once per frame
	void Update()
    {
	    if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("[KEY] Escape");
            eventManager.SendMessage("OnHitEscape");
        }
	}
}
