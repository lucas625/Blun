using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    //Inicializacao dos butoes
    public Button startButton;
    public Button personalizarButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButtonPress()
    {
        SceneManager.LoadScene(1);
    }

    public void PersonalizarButtonPress()
    {
        SceneManager.LoadScene(2);
    }
}
