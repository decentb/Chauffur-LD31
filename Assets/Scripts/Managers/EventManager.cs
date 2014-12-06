using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {

	// Use this for initialization
	void Start()
    {
	}

    void OnHitEscape()
    {
        Debug.Log("[EVENT] Quit Game");
        Application.Quit();
    }
	
	// Update is called once per frame
	void Update()
    {
	}
}
