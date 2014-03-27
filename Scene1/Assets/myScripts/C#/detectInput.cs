/// <summary>
/// 
/// dectectInput.cs
/// Developed by Aidan McCarthy
/// Student Number 20046537
/// Assignment: 3D Maze
/// Issues:
/// </summary>
using UnityEngine;
using System.Collections;

public class detectInput : MonoBehaviour {

	public Camera cam;//the camera for the minimap

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.F))//player presses f
		{
			var person = GameObject.Find("person");//finds the person controller
			person.light.enabled=!person.light.enabled;//toggles flashlight on or off
		}
		if(Input.GetKeyUp(KeyCode.P))//player presses p
		{
			cam.camera.enabled=!cam.camera.enabled;//disable minimap
		}
		if(Input.GetKeyUp(KeyCode.M))//player presses m
		{
			audio.enabled=!audio.enabled;
		}
		if(Input.GetAxis("Mouse ScrollWheel")<0.0)
		{
			var person = GameObject.Find("person");//finds the person controller
			person.light.intensity-=0.1f;
		}
		if(Input.GetAxis("Mouse ScrollWheel")>1.0)
		{
			var person = GameObject.Find("person");//finds the person controller
			person.light.intensity+=0.1f;
		}
	
	}
}
