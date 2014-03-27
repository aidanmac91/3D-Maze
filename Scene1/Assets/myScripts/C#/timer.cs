/// <summary>
/// 
/// timer.cs
/// Developed by Aidan McCarthy
/// Student Number 20046537
/// Assignment: 3D Maze
/// Issues:
/// </summary>
using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {

	
	float timeLeft = 240.0f;//the amount of time left

	// Use this for initialization
	void Start () {
	}

	
	void Update()
	{
		var clock=GameObject.Find("gameClock");//finds the guiText gameClock
		clock.guiText.text=("Time Left: "+timeLeft.ToString());//sets the text of the texture to the current time left

		timeLeft -= Time.deltaTime;//updates time
		if(timeLeft < 0)//time run out
		{
			Application.LoadLevel(3);//reloads failed scene
		}
	}
}
