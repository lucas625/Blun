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
    public string loginLevel= "LoginScene";
    public string cadastroLevel= "DumbScene";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoginButtonPress()
    {
        SceneManager.LoadScene(loginLevel);
    }

    public void CadastroButtonPress()
    {
        SceneManager.LoadScene(cadastroLevel);
    }
}
