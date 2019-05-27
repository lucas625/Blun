using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingMenu : MonoBehaviour {
	//Inicializacao dos butoes
	//Nome é irrelevante
    public Button LoadingButton;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadingButtonPress()
    {
        SceneManager.LoadScene(2);
    }
}
