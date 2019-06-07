using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuestStart : MonoBehaviour {
	//Inicializacao dos botoes
	//Nome é irrelevante
    public Button HomeButton;
    public Button AjudaButton;
    public Button TopLeftButton;
    public Button TopRightButton;
    //public Button TopLeftButton;
    //public Button TopRightButton;
    public string HomeLevel= "StartMenu";
<<<<<<< HEAD
    public string AjudaLevel= "";
    public string TopLeftLevel= "";
    public string TopRightLevel= "";
	// Use this for initialization
	void Start () {
		
	}
=======
    public string AjudaLevel= "DumbScene";
    public string TopLeftLevel= "DumbScene";
    public Text mensagem;
    // Use this for initialization
    void Start () {
        mensagem.text = "Olá " + PlayerPrefs.GetString("User") + ", eu sou Solus";

    }
>>>>>>> tela de usuario concluída. Falta ajustes de design
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HomeButtonPress()
    {
        SceneManager.LoadScene(HomeLevel);
    }

    public void AjudaButtonPress()
    {
        SceneManager.LoadScene(AjudaLevel);
    }

    public void TopLeftButtonPress()
    {
        SceneManager.LoadScene(TopLeftLevel);
    }

    public void TopRightButtonPress()
    {
        SceneManager.LoadScene("UserScene");

    }
}
