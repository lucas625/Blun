using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingMenu : MonoBehaviour {
	public float delay = 3;
	public string NewLevel= "QuestStart";
	// Use this for initialization
	void Start () {
		StartCoroutine(LoadLevelAfterDelay(delay));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator LoadLevelAfterDelay(float delay){
			yield return new WaitForSeconds(delay);
			SceneManager.LoadScene(NewLevel);
		}

}
