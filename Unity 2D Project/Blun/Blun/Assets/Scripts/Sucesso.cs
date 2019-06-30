using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sucesso : MonoBehaviour {
	public float delay = 1;
	public float i = 0;
	public string NewLevel1= "Tela_quests";
	public string NewLevel2= "Tela_quests";
	public string NewLevel3= "Tela_quests";
	public string NewLevel4= "Tela_quests";
	public string NewLevel5= "MissionComplete";
	
	// Use this for initialization
	void Start () {
		i=0;
		StartCoroutine(LoadLevelAfterDelay(delay));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
		i++;
			if(i==1){
				SceneManager.LoadScene(NewLevel1);
			}
			if(i==2){
				SceneManager.LoadScene(NewLevel2);
			}
			if(i==3){
				SceneManager.LoadScene(NewLevel3);
			}
			if(i==4){
				SceneManager.LoadScene(NewLevel4);
			}
			if(i==5){
				SceneManager.LoadScene(NewLevel5);
			}
		
	}	

}
