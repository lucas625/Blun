﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginMenu : MonoBehaviour {
	//Inicializacao dos butoes
	//Nome é irrelevante
    public Button LoginButton;
	public string nextLevel= "LoadingScene";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void goButtonPress()
    {
        SceneManager.LoadScene(nextLevel);
    }
}