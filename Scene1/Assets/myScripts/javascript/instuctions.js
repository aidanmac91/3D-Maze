/*

 instructions.js
 Developed by Aidan McCarthy
 Student Number 20046537
 Assignment: 3D Maze
 Issues: 
*/
#pragma strict

function Start () {

}

function Update () {

}

private var stringToEdit : String ="The goal of the game is to get through the maze before the timer runs out.\nHowever the exit is blocked by a cell door that needs 5 keys to unlock it.\nYou need to search the maze for these keys and get out before the timer runs out.";
	function OnGUI () {
		GameObject.Find("instructions").guiText.text=stringToEdit;//sets instructions text to stringToEdit
	}