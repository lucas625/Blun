using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UserInfo : MonoBehaviour
{
    public Button editarButton;
    public Button voltarButton;
    public Text userName;
    public Text userEmail;
    // Use this for initialization
    void Start()
    {
        Load();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void editarButtonPress()
    {
        SceneManager.LoadScene("UserEditScene");
    }

    public void voltarButtonPress()
    {
        SceneManager.LoadScene("QuestStart");
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
        userName.text = PlayerPrefs.GetString("User"); // Carrega informações do ultimo Jogador Jogado..
        userEmail.text = PlayerPrefs.GetString("email");
    }


}