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
        mensagem.text = "Pulem!";
    }
	
    // Update is called once per frame
    void Update () {
        if (CurrentValue < 1) {
            if(CurrentValue<0.20) {// modo mais devagar
                mensagem.text = "Vamos pulando devagar.";
                // play audio mais devagar
                if(Input.acceleration.z>0.002f) {
                    CurrentValue += 0.002f;
                }else if(Input.acceleration.z>0.0005f){
                    CurrentValue += Input.acceleration.z - 0.0005f;
                }else {
                    CurrentValue -= 0.0001f;
                }
            }
            else if(CurrentValue<0.50) {// modo mais rápido
                mensagem.text = "Vamos, pulem mais rápido!";
                // play audio mais rápido
                if(Input.acceleration.z>0.003f) {
                    CurrentValue += 0.003f;
                }else if(Input.acceleration.z>0.001f){
                    CurrentValue += Input.acceleration.z - 0.001f;
                }else {
                    CurrentValue -= 0.0005f;
                }
            }
            else if(CurrentValue<0.7) {// modo mais devagar
                mensagem.text = "Mais devagar!";
                // play audio mais devagar
                if(Input.acceleration.z>0.002f) {
                    CurrentValue += 0.002f;
                }else if(Input.acceleration.z>0.0005f){
                    CurrentValue += Input.acceleration.z - 0.0005f;
                }else {
                    CurrentValue -= 0.0001f;
                }
            }
            else{// modo mais rápido
                mensagem.text = "Pulem o mais rápido que vocês conseguirem!";
                // play audio pulem o mais rápido que vocês conseguirem
                if(Input.acceleration.z>0.004f) {
                    CurrentValue += 0.004f;
                }else if(Input.acceleration.z>0.0015f){
                    CurrentValue += Input.acceleration.z - 0.0015f;
                }else {
                    CurrentValue -= 0.0007f;
                }
            }
        } else {
            mensagem.text = "Parabéns Heróis, vocês Pularam bastante!";
        }
    }
    
    public void HomeButtonPress()
        {
            SceneManager.LoadScene("");
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
