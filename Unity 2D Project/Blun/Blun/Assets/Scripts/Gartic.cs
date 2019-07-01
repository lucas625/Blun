using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gartic : MonoBehaviour {
 public float contagem = 30;
 public string nome = "teste";
 public string nome1 = "teste";
 public string nome2 = "teste";
 public string SucessoScene = "Sucesso";
 public string TryAgainScene = "TryAgain";
 public InputField nameInputField;
 
 // Use this for initialization

 	// Update is called once per frame
 void Update () {
	if (nameInputField.text == nome || nameInputField.text == nome1 ||nameInputField.text == nome2)
	{
		 SceneManager.LoadScene(SucessoScene); 
	}
	if (contagem > 0) 
	{
		contagem -= Time.deltaTime;
	}
	else
	{
		SceneManager.LoadScene(TryAgainScene);
	}
	}
}
