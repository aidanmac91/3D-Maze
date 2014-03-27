	#pragma strict

	function Start () {
	//PlayerPrefs.SetInt("Score",)

	}

	function Update () {

	}

	var textFieldString = "text field";
	function OnGUI()
	{
	textFieldString = GUI.TextField (new Rect (25, 25, 100, 30), textFieldString);
	if(PlayerPrefs.HasKey("Score1"))
	{

	GUI.Label(Rect(400,100,160,40),PlayerPrefs.GetString("PlayerName")+" :"+ PlayerPrefs.GetString("Score1").ToString());
	Debug.Log(textFieldString.ToString());
	}
	}