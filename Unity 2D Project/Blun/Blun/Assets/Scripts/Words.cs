﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Words : MonoBehaviour {
 public string desenho = "teste";
 public string SucessoScene = "Sucesso";
 string word = null;
 int wordIndex = -1;
 string alpha = null;
 string alpha2 = null;
 public Text myWord = null;
 char [] wordChar = new char[30];
 //public Text index = null;
 
 // Use this for initialization

 public void alphabetFunction (string alphabet)
 {
	wordIndex++;
	char[] keepchar = alphabet.ToCharArray ();
	wordChar [wordIndex] = keepchar[0];
	alpha = wordChar [wordIndex].ToString ();
	word = word + alpha;
	myWord.text = word;
	if (word == desenho)
	{
		 SceneManager.LoadScene(SucessoScene); 
	}
 }
 public void backspaceFunction()
 {
	if (wordIndex >= 0) 
	{
		wordIndex--;
		alpha2 = null;
		for (int i = 0; i < wordIndex +1; i++){
			alpha2 = alpha2 + wordChar [i].ToString ();
		}
		word = alpha2;
		myWord.text = word;		
	}
	if (word == desenho)
	{
		 SceneManager.LoadScene(SucessoScene); 
	}
 }
 
}
