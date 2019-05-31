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
    //public Button TopLeftButton;
    //public Button TopRightButton;
    public string HomeLevel= "HomeScene";
    public string AjudaLevel= "DumbScene";
    public string TopLeftButton= "DumbScene";
    public string TopRightButton= "DumbScene";
	// Use this for initialization
	void Start () {
		
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
        SceneManager.LoadScene(TopLeftButton);
    }

    public void TopRightButtonPress()
    {
        SceneManager.LoadScene(TopRightButton);

    }
}
