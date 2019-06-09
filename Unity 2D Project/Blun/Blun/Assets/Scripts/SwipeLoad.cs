using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class SwipeLoad : MonoBehaviour {
    
    // Unity UI References
    public Slider slider;
    public Text displayText;
    private Touch pinchFinger1, pinchFinger2;
    
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
    }
	
    // Update is called once per frame
    void Update ()
    {
        // Teste para Unity PC
		if (Input.GetMouseButtonDown(0))
		{
			CurrentValue += 0.0043f;
		}

		if (Input.GetMouseButtonUp(0))
		{
		CurrentValue += 0.0043f;
		}

		//Taps em toque
		if (Input.touchCount >= 1)
			{
			if (Input.touches[0].phase == TouchPhase.Began){
				CurrentValue += 0.0043f;
			}

			if (Input.touches[0].phase == TouchPhase.Ended){
				CurrentValue += 0.0043f;
			}
		}
        
                
    }
}