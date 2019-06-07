using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginMenu : MonoBehaviour {
	//Inicializacao dos butoes
	//Nome é irrelevante
    public Button LoginButton;
    public InputField nameInputField;
    public InputField emailInputField;
    public InputField passwodInputField;

    public string nextLevel= "LoadingScene";
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

	public void goButtonPress()
    {
        if (nameInputField.text.Length > 0 && emailInputField.text.Length > 0 && passwodInputField.text.Length > 0)
        {
            Save(nameInputField.text, emailInputField.text, passwodInputField.text);
            SceneManager.LoadScene(nextLevel);
        }




    }

    public void Save(string userName, string userEmail, string userPass)
    {
        try
        {
            PlayerPrefs.SetString("User", userName);
            PlayerPrefs.SetString("email", userEmail);
            PlayerPrefs.SetString("password", userPass);

        }
        catch (System.Exception e)
        {
            //Provavelmente excedeu o Limite de 1Mb no WebPlayer
            Debug.LogError(e.ToString());
        }
        PlayerPrefs.Save();
    }
}
