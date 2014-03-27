/// <summary>
/// 
/// characterCollision.cs
/// Developed by Aidan McCarthy
/// Student Number 20046537
/// Assignment: 3D Maze
/// Issues:
/// </summary>
using UnityEngine;
using System.Collections;

public class characterCollision : MonoBehaviour {

	int numberOfKeys=0;//number of keys at beginning
	public AudioClip beep;//sound when keys are collected
	public Texture key1;//texture for 1 key collected
	public Texture key2;//texture for 2 keys collected
	public Texture key3;//texture for 3 keys collected
	public Texture key4;//texture for 4 keys collected
	public Texture key5;//texture for 5 keys collected
	public AudioClip door;//when door opens


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	void Update () {

	}

	/// <summary>
	/// Handles all the collisions event between the player and objects in the game
	/// </summary>
	/// <param name="hit">Hit.</param>
	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if (hit.collider.gameObject.tag == "key")//when the player interacts with a key
		{
			Destroy(hit.collider.gameObject);//destroy the instance of the key
			numberOfKeys=numberOfKeys+1;//increment the current number of keys
			audio.PlayOneShot(beep);//play the collect sound
		}

		switch (numberOfKeys)//decides on which guiTexture to display
		{
		case 1://one key
			GameObject.Find("guiTexture").guiTexture.texture=key1;
			break;
		case 2://two keys
			GameObject.Find("guiTexture").guiTexture.texture=key2;
			break;
		case 3://three keys
			GameObject.Find("guiTexture").guiTexture.texture=key3;
			break;
		case 4://four keys
			GameObject.Find("guiTexture").guiTexture.texture=key4;
			break;
		case 5://five keys
			GameObject.Find("guiTexture").guiTexture.texture=key5;
			break;

		}

		if(hit.collider.gameObject.tag == "endPoint"&&numberOfKeys==5)//when the player reaches the end of the level with
			//correct number of keys
		{
			Application.LoadLevel(4);
			PlayerPrefs.SetString("Score1",(GameObject.Find("gameClock").guiText.text));//sets time finished
			PlayerPrefs.SetString("PlayerName","Aidan");//sets name
			PlayerPrefs.Save();//save

		}

		if(hit.collider.gameObject.tag == "door"&&numberOfKeys == 5)//when the player tries to open the door when they
			//do have enough keys
		{
			audio.PlayOneShot(door);//plays sound
			Destroy(hit.gameObject);//destroys door

		}

		if(hit.collider.gameObject.tag == "door"&&numberOfKeys != 5)//when the player tries to open the door when they
			//do have enough keys
		{
			GameObject.Find("warning").guiText.text="You need to collect more keys";//displays message to player
		}

		if(hit.collider.gameObject.tag=="endMessage")//when the player has collided with certain wall resets guiText to blank
		{
			GameObject.Find("warning").guiText.text="";
		}

	}

}
