using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingMenu : MonoBehaviour {
<<<<<<< HEAD:Unity 2D Project/Blun/Blun/Assets/Scripts/LoadingMenu.cs
	public float delay = 1;
	public string NewLevel= "Tela_quests";
=======

    public float delay = 3;
	public string NewLevel= "QuestStart";
>>>>>>> script com persistencia concluido:Unity 2D Project/Blun/Blun/Assets/Scripts/loadingMenu.cs
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
        SceneManager.LoadScene(NewLevel);
    }

}
