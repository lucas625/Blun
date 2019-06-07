using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_1 : MonoBehaviour {
	//Inicializacao dos butoes
	//Nome é irrelevante
    	public Button Game_1_Button;
		public string Aventura1Scene= "Aventura1Scene";
    	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Aventura1Scene_ButtonPress()
    	{
        	SceneManager.LoadScene(Aventura1Scene);
    	}

}
