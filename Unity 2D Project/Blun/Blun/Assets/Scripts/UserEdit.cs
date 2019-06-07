using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UserEdit : MonoBehaviour
{
    public Button okButton;
    public Button cancelButton;
    public InputField nameInputField;
    public InputField emailInputField;
    // Use this for initialization
    void Start()
    {
        Load();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void okButtonPress()
    {
        Save(nameInputField.text, emailInputField.text);
        SceneManager.LoadScene("UserScene");
    }

    public void cancelButtonPress()
    {
        SceneManager.LoadScene("UserScene");
    }

    public void Save(string userName, string userEmail)
    {
        try
        {
            PlayerPrefs.SetString("User", userName);
            PlayerPrefs.SetString("email", userEmail);

        }
        catch (System.Exception e)
        {
            //Provavelmente excedeu o Limite de 1Mb no WebPlayer
            Debug.LogError(e.ToString());
        }
        PlayerPrefs.Save();
    }
    public void Load()
    {
        if (!PlayerPrefs.HasKey("User"))
        {
            //Primeira vez jogando, cria um novo jogador
            Save("sem nome", "sem email");
        }
        nameInputField.text = PlayerPrefs.GetString("User"); // Carrega informações do ultimo Jogador Jogado..
        emailInputField.text = PlayerPrefs.GetString("email");
    }
}
