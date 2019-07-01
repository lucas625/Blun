using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sucesso : MonoBehaviour {
	public float delay = 1;
	public static float i;
	public string NewLevel1= "Tela_quests";
	public string NewLevel2= "Tela_quests";
	public string NewLevel3= "Tela_quests";
	public string NewLevel4= "Tela_quests";
	public string NewLevel5= "MissionComplete";
	
	// Use this for initialization
	void Start () {
		StartCoroutine(LoadLevelAfterDelay(delay));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
			if(i==0){
				i++;
				SceneManager.LoadScene(NewLevel1);
			}
			else if(i==1){
				i++;
				SceneManager.LoadScene(NewLevel2);
			}
			else if(i==2){
				i++;
				SceneManager.LoadScene(NewLevel3);
			}
			else if(i==3){
				i++;
				SceneManager.LoadScene(NewLevel4);
			}
			else if(i==4){
				SceneManager.LoadScene(NewLevel5);
			}
		
	}	

}
