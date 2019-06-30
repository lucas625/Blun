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
    private IEnumerator timer;
    private static int resRow=0;
    private List<string> respostas = new List<string>();
    private List<List<string>> dicas = new List<List<string>>();
    private List<Text> dicasTexts = new List<Text>();
    public AudioSource FraseInicio=null;
    
	
	// Use this for initialization
	void Start () {
        textDica1.text = "-";
        textDica2.text = "-";
        textDica3.text = "-";
        textDica4.text = "-";
        textDica5.text = "-";
        textDica6.text = "-";

        

        initializeDicas(dicasTexts);

        
        
        
        //Charada 1
        dicas.Add(new List<string> {"2 vezes em um minuto", "3 vezes em um momento", "1 vez em cem anos"});
        respostas.Add("Letra M");
        //Charada 2
        dicas.Add(new List<string> {"Não é vivo", "Tem 5 dedos", "-"});
        respostas.Add("Luvas");
        //Charada 3
        dicas.Add(new List<string> {"Se me alimentar, eu vivo", "Se me der de beber, eu morrerei", "-"});
        respostas.Add("Fogo");
        //Charada 4
        dicas.Add(new List<string> {"Se molha, enquanto seca", "-", "-"});
        respostas.Add("Toalha");
        //Charada 5
        dicas.Add(new List<string> {"Estou sempre entre terra e céu", "Costumo estar longe", "Se você se aproxima, eu me afasto"});
        respostas.Add("O horizonte");

        //Random rnd = new Random();
        FraseInicio.Play();
        timer = Timer(30);
        StartCoroutine(timer);
        
	}

    float currCountdownValue;
    public IEnumerator StartCountdown(float countdownValue, List<List<string>> dicas, List<Text> dicasLabels, int index, int row)
    {
        dicasLabels[index].text=dicas[row][index];
        if(index<3){
            //Debug.Log("Entrando no IF");
            currCountdownValue = countdownValue;
            while (currCountdownValue > 0)
            {
                //Debug.Log("Entrando no WHILE");
                yield return new WaitForSeconds(1.0f);
                currCountdownValue--;
            }
            index++;
            if(index==3){
                row++;
                //Debug.Log("Corroutine: "+resRow);
                resRow++;
                index=0;
                clean(dicasLabels);
                
                StartCoroutine(StartCountdown(countdownValue, dicas, dicasLabels, index, row));
            }else{
                StartCoroutine(StartCountdown(countdownValue, dicas, dicasLabels, index, row));
            }
        }
        
    }

    float currCountdownValue2;
    public IEnumerator Timer(float countdownValue)
    {
        currCountdownValue2 = countdownValue;
        while (currCountdownValue2 > 0)
        {
            //Debug.Log("Entrando no WHILE");
            yield return new WaitForSeconds(1.0f);
            currCountdownValue2--;
        }
        coroutine = StartCountdown(20, dicas, dicasTexts, 0, 0);
        StartCoroutine(coroutine);
    }
    void initializeDicas(List<Text> dicas){
        dicas.Add(textDica1);
        dicas.Add(textDica2);
        dicas.Add(textDica3);
        dicas.Add(textDica4);
        dicas.Add(textDica5);
        dicas.Add(textDica6);
    }

    void clean(List<Text> dicas){
        
        foreach (Text item in dicas){
            item.text="-";
        }
    }
	
	// Update is called once per frame
	void Update () {
        
        if(respostas[resRow].ToLower()==resposta.text.ToLower()){
            resposta.color = Color.green;
        }else{
            resposta.color = Color.red;
        }
        //Debug.Log(respostas[resRow]);
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
