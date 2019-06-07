using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public Button finishButton;
    public Text labelCongrats;
    public Text scoreValue;
    // Use this for initialization
    void Start()
    {
        labelCongrats.text = "Parabéns " + PlayerPrefs.GetString("User") + "! Você concluíu a aventura com sucesso.";
        scoreValue.text = PlayerPrefs.GetInt("score").ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void finishButtonPress()
    {
        SceneManager.LoadScene("QuestStart");
    }

}