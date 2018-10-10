using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public GameObject collectObject;
    public bool takeObject;
    GUISkin guiMessage;

    private void OnTriggerEnter(Collider playerStatus)
    {
        if (playerStatus.gameObject.tag == "Player")
        {
            takeObject = true;
        }
    }

    private void OnTriggerExit(Collider playerStatus)
    {
        if (playerStatus.gameObject.tag == "Player")
        {
            takeObject = false;
        }   
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (takeObject)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Destroy(collectObject.gameObject);
            }
        }
	}

    private void OnGUI()
    {
        GUI.skin = guiMessage;

        if (takeObject)
        {
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 55, 120, 50), "PickUp Object");
        }
    }
}
