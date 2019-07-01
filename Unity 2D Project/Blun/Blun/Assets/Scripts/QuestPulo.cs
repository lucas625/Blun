using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class QuestPulo : MonoBehaviour {
    
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
    public AudioClip[] aAntes = new AudioClip[18];
    private string[] fAntes = new string[18];
    public AudioClip[] aDepois = new AudioClip[2];
    private string[] fDepois = new string[2];

    private string[] fDurante = new string[8];
    public AudioClip[] aDurante = new AudioClip[8];
    
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
        // falas depois
        fDepois[0] = "Parabéns heróis! Conseguimos,";
        fDepois[1] = "vamos agora para nossa próxima missão!";
        fAntes[0] = "Enquanto vocês estavam procurando as peças para trancar o portal do mal,";
        // falas antes
        fAntes[1] = "eu estava procurando mais informações sobre os planos do vilão.";
        fAntes[2] = "Agora que o portal foi selado,";
        fAntes[3] = "ele quer utilizar magia do sono";
        fAntes[4] = "para fazer as pessoas do mundo dormirem para sempre!";
        fAntes[5] = "Descobri um contra feitiço";
        fAntes[6] = "que fará o vilão não soltar essa magia";
        fAntes[7] = "no nosso planeta!";
        fAntes[8] = "Heróis, preciso da energia dos seus movimentos";
        fAntes[9] = "para criar um contra-feitiço.";
        fAntes[10] = "Só então terei a energia suficiente";
        fAntes[11] = "para utilizar a magia que irá anular o feitiço do sono";
        fAntes[12] = "que o vilão está preparando!";
        fAntes[13] = "Vamos pular para agitar e derrotar o vilão!";
        fAntes[14] = "Temos que encher nossa barra de energia";
        fAntes[15] = "antes do vilão conseguir soltar o feitiço do sono eterno!";
        fAntes[16] = "Por favor, heróis, me emprestem";
        fAntes[17] = "a energia de seus movimentos!";
        // falas durante
        fDurante[0] = "Vamos pulando devagar.";
        fDurante[1] = "Vamos, pulem mais rápido!";
        fDurante[2] = "Mais devagar!";
        fDurante[3] = "Pulem com um pé só!";
        fDurante[4] = "Pulem com o outro pé!";
        fDurante[5] = "Pulando e girando!";
        fDurante[6] = "Pulando e imitando um monstro pra espantar o vilão";
        fDurante[7] = "Pulando de um lado para o outro com um pé só!";
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
                    if(Input.acceleration.z>0.004f) {
                        CurrentValue += 0.004f;
                    }else if(Input.acceleration.z>0.0005f){
                        CurrentValue += Input.acceleration.z - 0.0005f;
                    }else {
                        CurrentValue -= 0.0001f;
                    }
                }
                else if(CurrentValue<0.30) {// modo mais rápido
                    if(!vozlunosDurante.isPlaying) {
                        playS(aDurante[1], vozlunosDurante, fDurante[1], mensagem);
                    }
                    if(Input.acceleration.z>0.0025f) {
                        CurrentValue += 0.0025f;
                    }else if(Input.acceleration.z>0.001f){
                        CurrentValue += Input.acceleration.z - 0.001f;
                    }else {
                        CurrentValue -= 0.0006f;
                    }
                }
                else if(CurrentValue<0.40) {// modo mais devagar
                    if(!vozlunosDurante.isPlaying) {
                        playS(aDurante[2], vozlunosDurante, fDurante[2], mensagem);
                    }
                    if(Input.acceleration.z>0.004f) {
                        CurrentValue += 0.004f;
                    }else if(Input.acceleration.z>0.0005f){
                        CurrentValue += Input.acceleration.z - 0.0005f;
                    }else {
                        CurrentValue -= 0.0003f;
                    }
                }
                else if(CurrentValue<0.5) {// um pé
                    if(!vozlunosDurante.isPlaying) {
                        playS(aDurante[3], vozlunosDurante, fDurante[3], mensagem);
                    }
                    if(Input.acceleration.z>0.0025f) {
                        CurrentValue += 0.0025f;
                    }else if(Input.acceleration.z>0.0007f){
                        CurrentValue += Input.acceleration.z - 0.0007f;
                    }else {
                        CurrentValue -= 0.0004f;
                    }
                }
                else if(CurrentValue<0.6) {// um pé
                    if(!vozlunosDurante.isPlaying) {
                        playS(aDurante[4], vozlunosDurante, fDurante[4], mensagem);
                    }
                    if(Input.acceleration.z>0.0025f) {
                        CurrentValue += 0.0025f;
                    }else if(Input.acceleration.z>0.0007f){
                        CurrentValue += Input.acceleration.z - 0.0007f;
                    }else {
                        CurrentValue -= 0.0004f;
                    }
                }
                else if(CurrentValue<0.75) {// pulando e girando
                    if(!vozlunosDurante.isPlaying) {
                        playS(aDurante[5], vozlunosDurante, fDurante[5], mensagem);
                    }
                    if(Input.acceleration.z>0.003f) {
                        CurrentValue += 0.003f;
                    }else if(Input.acceleration.z>0.0005f){
                        CurrentValue += Input.acceleration.z - 0.0005f;
                    }else {
                        CurrentValue -= 0.0004f;
                    }
                }
                else if(CurrentValue<0.9) {// imitando
                    if(!vozlunosDurante.isPlaying) {
                        playS(aDurante[6], vozlunosDurante, fDurante[6], mensagem);
                    }
                    if(Input.acceleration.z>0.0020f) {
                        CurrentValue += 0.0020f;
                    }else if(Input.acceleration.z>0.0005f){
                        CurrentValue += Input.acceleration.z - 0.0005f;
                    }else {
                        CurrentValue -= 0.0002f;
                    }
                }
                else{// final
                    if(!vozlunosDurante.isPlaying) {
                        playS(aDurante[7], vozlunosDurante, fDurante[7], mensagem);
                    }
                    if(Input.acceleration.z>0.001f) {
                        CurrentValue += 0.001f;
                    }else if(Input.acceleration.z>0.0006f){
                        CurrentValue += Input.acceleration.z - 0.0006f;
                    }else {
                        CurrentValue -= 0.0003f;
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
                playS(aDepois[0], vozlunos, fDepois[0], mensagem);
                clicks = 19;
                ready = false;
            }
        }
    }
    // Update is called once per frame
    void Update () {
        fUp();
    }
    public void SolusClick() {
        if(clicks<18) {
            clicks += 1;
            playS(aAntes[clicks], vozlunos, fAntes[clicks], mensagem);
        }else if(clicks==18 && ready==false){
            playS(aDurante[0], vozlunosDurante, fDurante[0], mensagem);
            ready = true;
        }
        else if(clicks==19) {
            clicks += 1;
            playS(aDepois[1], vozlunos, fDepois[1], mensagem);
        }else if(clicks==20) {
            SceneManager.LoadScene("NewGartic 1");
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
