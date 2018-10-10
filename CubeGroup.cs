using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGroup : MonoBehaviour {

    public GameObject[] cubeItems;
    public int cubeCount = 0;
    public int cubeAdded = 0;

    GUISkin cubeMessage;


	// Use this for initialization
	void Start () {
        cubeItems = GameObject.FindGameObjectsWithTag("CubeItem");
        cubeCount = cubeItems.Length;
	}
	
	// Update is called once per frame
	void Update () {
        cubeItems = GameObject.FindGameObjectsWithTag("CubeItem");
        CubeCollected();
	}

    public void CubeCollected()
    {
        if (cubeItems.Length < cubeCount)
        {
            cubeAdded += 1;
            cubeCount = cubeItems.Length;
        }
    }

    public void OnGUI()
    {
        GUI.skin = cubeMessage;
        GUI.Label(new Rect(0, 0, 120, 60), "Cube Added : " + cubeAdded);
    }
}
