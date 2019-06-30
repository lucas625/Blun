using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class QuestRunas2 : MonoBehaviour {
    
    // Unity UI References
    // Loadingbar
    public Slider slider;
    public Text displayText;
    // Mensagem que aparece para o usuário
    public Text mensagem;

    // vozes e seus respectivos textos
    public AudioClip[] paudio = new AudioClip[10];
    public AudioSource vozlunos;
    public AudioSource vozlunosDurante;
    public AudioClip[] aAntes = new AudioClip[19];
    private string[] fAntes = new string[19];
	
	public AudioClip[] aDurante = new AudioClip[3];
    private string[] fDurante = new string[3];
	
    public AudioClip[] aDepois = new AudioClip[3];
    private string[] fDepois = new string[3];

	
    private bool ready = false;
    // fim vozes e textos
    private int clicks = 0;
    // Create a property to handle the slider's value
    private float currentValue = 0f;
    public float CurrentValue {
        get {
            return currentValue;
        }
        set {
            currentValue = value;
            slider.value = currentValue;
            displayText.text = (slider.value * 100).ToString("0") + "%";
        }
    }

    // Use this for initialization
    void Start () {
        CurrentValue = 0f;
        // falas antes
        fAntes[0] = "O vilão está tentando invadir nossa festa";
		fAntes[1] = "Usando um portal maligno";
        fAntes[2] = "Não podemos deixar que ele consiga abrir esse portal.";
        fAntes[3] = "Eu tenho um plano";
		fAntes[4] = "Mas preciso da ajuda de vocês";
		fAntes[5] = "Para conseguirmos vencer esse vilão";
		fAntes[6] = "Nossos celulares serão varinhas";
        fAntes[7] = "Precisamos balançar nossas varinhas";
        fAntes[8] = "Se o movimento for correto";
        fAntes[9] = "Vamos enchendo a barra de energia";
        fAntes[10] = "Quando a barra de energia";
        fAntes[11] = "Estiver completa";
        fAntes[12] = "O portal será trancado!";
        fAntes[13] = "Não temos muito tempo";
        fAntes[14] = "O vilão já começou a abrir o portal";
        fAntes[15] = "Para invadir nossa festa e acabar com nossa alegria";
        fAntes[16] = "O portal se abrirá logo!";
        fAntes[17] = "Vamos heróis, procurem pelas peças mágicas!";
		fAntes[18] = "Elas estão em algum lugar aqui perto! Vamos procurar!";

        // falas durante
        fDurante[0] = "Heróis, será que conseguiremos achar mais?";
        fDurante[1] = "Estamos quase achando! Falta pouco...	";
        fDurante[2] = "Parabéns! Vamos para a próxima runa!...";
		// falas depois
        fDepois[0] = "Parabéns heróis! Conseguimos!";
		fDepois[1] = "Mas o vilão escapou...";
        fDepois[2] = "Vamos derrotá-lo na próxima missão!";
        //executando
        playS(aAntes[0], vozlunos, fAntes[0], mensagem);
    }
	
    private void playS(AudioClip c, AudioSource ase, string txt, Text m) {
        // toca um audio e altera a mensagem
        m.text = txt;
        ase.clip = c;
        ase.Play();
    }

    private void fUp() {
        if (ready) {
            if (CurrentValue < 1) {
                int maiorAtual = 0;
                if (CurrentValue>10)
                    maiorAtual = 10;
                if (CurrentValue>20)
                    maiorAtual = 20;
                if (CurrentValue>30)
                    maiorAtual = 30;
                if (CurrentValue>40)
                    maiorAtual = 40;
                if (CurrentValue>50)
                    maiorAtual = 50;
                if (CurrentValue>60)
                    maiorAtual = 60;
                if (CurrentValue>70)
                    maiorAtual = 70;
                if (CurrentValue>80)
                    maiorAtual = 80;
                if (CurrentValue>90)
                    maiorAtual = 90;
                if(CurrentValue<0.15) {// modo mais devagar
					if (Input.touchCount >= 1) {
					if (Input.touches[0].phase == TouchPhase.Began){
						CurrentValue += 0.0043f;
					}

					if (Input.touches[0].phase == TouchPhase.Ended){
						CurrentValue += 0.0043f;
					}
				}
                }
                else if(CurrentValue<0.50) {// modo mais rápido
                    if(!vozlunosDurante.isPlaying) {
                        playS(aDurante[1], vozlunosDurante, fDurante[1], mensagem);
                    }
                    if (Input.touchCount >= 1) {
					if (Input.touches[0].phase == TouchPhase.Began){
						CurrentValue += 0.0043f;
					}

					if (Input.touches[0].phase == TouchPhase.Ended){
						CurrentValue += 0.0043f;
					}
				}
                }
                
                else{// final
                    if(!vozlunosDurante.isPlaying) {
                        playS(aDurante[2], vozlunosDurante, fDurante[2], mensagem);
                    }
                 if (Input.touchCount >= 1) {
					if (Input.touches[0].phase == TouchPhase.Began){
						CurrentValue += 0.0043f;
					}

					if (Input.touches[0].phase == TouchPhase.Ended){
						CurrentValue += 0.0043f;
					}
				}
                }
                if(CurrentValue>=90 && maiorAtual<90){
                    vozlunos.clip = paudio[8];
                    vozlunos.Play();
                }
                else if(CurrentValue>=80 && maiorAtual<80){
                    vozlunos.clip = paudio[7];
                    vozlunos.Play();
                }
                else if(CurrentValue>=70 && maiorAtual<70){
                    vozlunos.clip = paudio[6];
                    vozlunos.Play();
                }
                else if(CurrentValue>=60 && maiorAtual<60){
                    vozlunos.clip = paudio[5];
                    vozlunos.Play();
                }
                else if(CurrentValue>=50 && maiorAtual<50){
                    vozlunos.clip = paudio[4];
                    vozlunos.Play();
                }
                else if(CurrentValue>=40 && maiorAtual<40){
                    vozlunos.clip = paudio[3];
                    vozlunos.Play();
                }
                else if(CurrentValue>=30 && maiorAtual<30){
                    vozlunos.clip = paudio[2];
                    vozlunos.Play();
                }
                else if(CurrentValue>=20 && maiorAtual<20){
                    vozlunos.clip = paudio[1];
                    vozlunos.Play();
                }
                else if(CurrentValue>=10 && maiorAtual<10){
                    vozlunos.clip = paudio[0];
                    vozlunos.Play();
                }
            } else {
                //playS(aDepois[0], vozlunos, fDepois[0], mensagem);
                clicks = 20;
                ready = false;
            }
        }
    }
    // Update is called once per frame
    void Update () {
        fUp();
    }
    public void SolusClick() {
        if(clicks<19) {
            clicks += 1;
            playS(aAntes[clicks], vozlunos, fAntes[clicks], mensagem);
        }else if(clicks==19 && ready==false){
            playS(aDurante[0], vozlunosDurante, fDurante[0], mensagem);
            ready = true;
        }
        else if(clicks<23 && ready==false) {
            clicks += 1;
            playS(aDepois[clicks-21], vozlunos, fDepois[clicks-21], mensagem);
        }else if(clicks==23) {
            SceneManager.LoadScene("QuestPulo");
        }
    }
    public void HomeButtonPress()
        {
            SceneManager.LoadScene("QuestStart");
        }

        public void AjudaButtonPress()
        {
            SceneManager.LoadScene("");
        }

        public void TopLeftButtonPress()
        {
            SceneManager.LoadScene("");
        }

        public void TopRightButtonPress()
        {
            SceneManager.LoadScene("UserScene");

        }

}
