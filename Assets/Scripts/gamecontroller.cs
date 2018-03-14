﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamecontroller : MonoBehaviour {

	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardcount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public Text scoreText;
	private int score;
	IEnumerator SpawnWave()
	{
		yield return new WaitForSeconds(startWait);
		while(true)
		{
			for(int i=0;i<hazardcount;i++)
			{
				Vector3 spawnPosition=new Vector3(Random.Range(-spawnValues.x,spawnValues.x),spawnValues.y,spawnValues.z);
				Quaternion spawnRotation=Quaternion.identity;
				Instantiate(hazard,spawnPosition,spawnRotation);
				yield return new WaitForSeconds(spawnWait);
			}
			yield return new WaitForSeconds(waveWait);
		}	
	}
	void Start(){
		score=0;
		UpdateScore();
		StartCoroutine( SpawnWave());
	}
	void UpdateScore()
	{
		scoreText.text="Score:"+score;
	}
	public void AddScore(int newScoreValue)
	{
		score+=newScoreValue;
		UpdateScore();
	}
}
