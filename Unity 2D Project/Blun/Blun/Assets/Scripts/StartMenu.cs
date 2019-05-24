using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour {
	//Inicializacao dos butoes
	//Nome é irrelevante
    public Button LoginButton;
    public Button CadastroButton;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoginButtonPress()
    {
        SceneManager.LoadScene(1);
    }

    public void CadastroButtonPress()
    {
        SceneManager.LoadScene(2);
    }
}
