/// <summary>
//// characterCollision.cs
/// Developed by Aidan McCarthy
/// Student Number 20046537
/// Assignment: 3D Maze
/// Issues:
/// </summary>
using UnityEngine;
using System.Collections;

public class mainMenuBts : MonoBehaviour {

	public bool isQuitButton =false;//is the button QUIT
	public string levelToLoad;//what level to load on click
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp()
	{
		if(isQuitButton)//if quit
		{
			Application.Quit();//application quit
		}
		else
		{
			Application.LoadLevel(levelToLoad);//load next level
		}
	}
}
