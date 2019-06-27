using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Timers;
using System.Linq;

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
    private IEnumerator coroutine;
    private string respostaCerta = "Pato";
	
	// Use this for initialization
	void Start () {
        textDica1.text = "Dica 1";
        textDica2.text = "Dica 2";
        textDica3.text = "Dica 3";
        textDica4.text = "Dica 4";
        textDica5.text = "Dica 5";
        textDica6.text = "Dica 6";

        List<Text> dicasTexts = new List<Text>();

        initializeDicas(dicasTexts);

        List<string> dicas = new List<string>();

        dicas.Add("Faz quack");
        dicas.Add("Nada");
        dicas.Add("Mora no lago");
        dicas.Add("Bota ovo");
        dicas.Add("Já chega");
        dicas.Add("Acabou a dica");

        coroutine = StartCountdown(20, dicas, dicasTexts, 0);
        StartCoroutine(coroutine);
        
        

	}

    float currCountdownValue;
    public IEnumerator StartCountdown(float countdownValue, List<string> dicas, List<Text> dicasLabels, int index)
    {
            dicasLabels[index].text=dicas[index];
        if(index<5){
            currCountdownValue = countdownValue;
            while (currCountdownValue > 0 && respostaCerta.ToLower()!=resposta.text.ToLower())
            {
                //Debug.Log("Countdown: " + currCountdownValue);
                yield return new WaitForSeconds(1.0f);
                currCountdownValue--;
            }
            index++;
            StartCoroutine(StartCountdown(countdownValue, dicas, dicasLabels, index));
        }
        
    }

    void initializeDicas(List<Text> dicas){
        dicas.Add(textDica1);
        dicas.Add(textDica2);
        dicas.Add(textDica3);
        dicas.Add(textDica4);
        dicas.Add(textDica5);
        dicas.Add(textDica6);
    }

	
	// Update is called once per frame
	void Update () {
        
        //Debug.Log("Rodando");
        if(respostaCerta.ToLower()==resposta.text.ToLower()){
            //Debug.Log(resposta.text);
            //StopCoroutine(coroutine);
            resposta.color = Color.green;
        }else{
            resposta.color = Color.red;
        }
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
