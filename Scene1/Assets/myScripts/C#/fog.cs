/// <summary>
/// 
///fog.cs
/// Developed by Aidan McCarthy
/// Student Number 20046537
/// Assignment: 3D Maze
/// Issues: Found script online, tried to get it to work for maplight but it didnt work
/// </summary>
using UnityEngine;
using System.Collections;

public class fog : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	[SerializeField] bool enableFog = false;//sets the default value to false
	//public bool enableSecondLight=false;
	
	bool previousFogState;
	//bool previousLightState;

	/// <summary>
	/// Prevents fog being render
	/// </summary>
	void OnPreRender()
	{
		previousFogState = RenderSettings.fog;
		RenderSettings.fog = enableFog;
	}
	 
	/// <summary>
	/// Reactivates fog for the main camera
	/// </summary>
	void OnPostRender()
	{
		RenderSettings.fog = previousFogState;
		//GameObject.Find("MapLight").light.enabled=previousLightState;
	}    
}
