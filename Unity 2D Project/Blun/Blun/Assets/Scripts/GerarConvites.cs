﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GerarConvites : MonoBehaviour {
	//Inicializacao dos butoes
	//Nome é irrelevante
    	public Button GerarButton;
		public string TelaQuestsStart= "QuestStart";
    	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GerarButtonPress()
    	{
        	SceneManager.LoadScene(TelaQuestsStart);
    	}

}
