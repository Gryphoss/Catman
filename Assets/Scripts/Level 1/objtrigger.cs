﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objtrigger : MonoBehaviour {

    public Text objectiveText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("detecting");

            objectiveText.text = "Objective: Find a tool to break the chain!";
        }
    }
}
