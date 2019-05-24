using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Voltar_Tela_quests : MonoBehaviour {
	//Inicializacao dos butoes
	//Nome é irrelevante
    	public Button Voltar_Tela_questsButton;
    	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Voltar_Tela_questsButtonPress()
    	{
        	SceneManager.LoadScene(1);
    	}

}
