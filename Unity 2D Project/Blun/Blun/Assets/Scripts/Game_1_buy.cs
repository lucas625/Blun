using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_1_buy : MonoBehaviour {
	//Inicializacao dos butoes
	//Nome é irrelevante
    	public Button Game_1_buy_Button;
		public string Aventura1_buy= "Aventura1_buy";
    	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Aventura1_buy_ButtonPress()
    	{
        	SceneManager.LoadScene(Aventura1_buy);
    	}

}
