﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class blocoColorido : MonoBehaviour {

	public	string	nomeFases;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){

		if (col.tag == "Personagem"){
			SceneManager.LoadScene(nomeFases) ;
		}
	}
}
