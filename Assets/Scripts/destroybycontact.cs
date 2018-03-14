using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroybycontact : MonoBehaviour {
	public GameObject explotion;
	public GameObject playerexplotion;
	public int scorevalue;
	private gamecontroller gameController;
	void Start()
	{
		GameObject gameControllerObject=GameObject.FindWithTag("GameController");
		if(gameControllerObject!=null)
		{
			gameController=gameControllerObject.GetComponent<gamecontroller>();
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.tag=="boundary")
		{
			return;
		}
		Instantiate(explotion,transform.position,transform.rotation);
		if(other.tag=="player")
		{
			Instantiate(playerexplotion,transform.position,transform.rotation);
		}
		gameController.AddScore(scorevalue);
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
