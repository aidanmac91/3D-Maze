/// <summary>
/// 
/// rotate.cs
/// Developed by Aidan McCarthy
/// Student Number 20046537
/// Assignment: 3D Maze
/// Issues:
/// </summary>
using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//rotates objects such as keys
		transform.Rotate(Vector3.right * Time.deltaTime*20);
		transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
	}
}
