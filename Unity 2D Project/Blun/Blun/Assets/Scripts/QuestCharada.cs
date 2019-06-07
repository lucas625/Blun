using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuestCharada : MonoBehaviour {
	//Inicializacao dos botoes
	//Nome é irrelevante
    public Button HomeButton;
    public Button AjudaButton;
    public Button TopLeftButton;
    public Button TopRightButton;
    //public Button TopLeftButton;
    //public Button TopRightButton;
    public string HomeLevel= "StartMenu";
    public string AjudaLevel= "";
    public string TopLeftLevel= "";
    public string TopRightLevel= "";
    public Text textDica1;
    public Text textDica2;
    public Text textDica3;
    public Text textDica4;
    public Text textDica5;
    public Text textDica6;
    public Text resposta;
	// Use this for initialization
	void Start () {
        textDica1.text = "Dica 1";
        textDica2.text = "Dica 2";
        textDica3.text = "Dica 3";
        textDica4.text = "Dica 4";
        textDica5.text = "Dica 5";
        textDica6.text = "Dica 6";
        
	}
	
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
