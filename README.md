3D-Maze
=======

Game link: http://htmlpreview.github.io/?https://github.com/aidanmac91/3D-Maze/blob/master/Scene1/AidanMcCarthy/AidanMcCarthy.html

Goals

The goal of the game is to get through the maze before the timer runs out.  However is blocked by a cell door that needs 5 keys to unlock it.  You need to search the maze for these keys and get out before the timer runs out.

Features

•	Collision detection 
o	Collisions between character and keys
•	Detects when the player collides with the key objects
•	Increases the number of keys displayed
o	Collisions between character and door
•	If the user has the correct number of keys
•	Door opens
•	If not 
•	Message is displayed to player
o	Collision between character and endpoint
•	Application displays end screen
o	Collisions between character and endMessage
•	Disables the GUIText that is display when the player tries to exit through the door.

•	3D primitives
o	The walls are cubes

•	Lights 
o	No global light (no sun)
o	There is a spotlight (acting as a flashlight) that is attached to the player
o	Each key has a point light on it to ensure the player can see it. 
o	There is a light so that the mini map can be scene
•	GUIText components 
o	Timer 
•	Located in the top right corner of the screen, the timer is displayed as it count downs to zero
•	GUITexture components 
o	Keys
•	The number of keys is displayed in the button right hand corner.  The number of keys increase as the keys are collected
•	Scripting (C#) 
o	characterCollisions.cs
•	Handles the events when the player interacts with an object
o	detectInput.cs
•	Handles when a button is pressed
•	P: hides the mini map
•	F: turns on and off the flashlight
o	Rotate.cs
•	Rotates objects
•	Applied to door
•	Applied to the keys
o	Timer.cs
•	Handles all events involved with the timer
o	mainMenuBts.cs
•	Handles when the buttons on menu are pressed 
•	Scripting (JavaScript)
o	Instructions.js
•	Handles displaying the instructions to the player
o	leaderboard.js
•	Handles displaying the highest scores
•	FPS view 
•	Texture 
o	Textures are applied to the walls
•	Ambient sound 
o	Horror sounds during the game
o	Collection sound when keys are collected
•	3D objects 
o	Keys
o	Door
•	Detection of key inputs 
o	P
•	Hides mini map
o	F
•	Turns on/off the light
o	M
•	Turn on/off sounds
o	Mouse wheel up
•	Turns down the intensity of the flashlight
o	Mouse wheel down
•	Turns up the intensity of the flashlight

Assets
•	Keys: http://www.turbosquid.com/3d-models/old-key-3ds/448201
•	Wall texture: http://www.turbosquid.com/3d-models/free-damaged-wall-3d-model/747378
•	Key GUI: http://icons.iconarchive.com/icons/visualpharm/must-have/256/Key-icon.png
•	Scary music: Free Horror Music Pack, Unity Asset Store
•	Collection sound: http://www.freesound.org/people/timmy_h123/sounds/160503/download/160503__timmy-h123__item-05.wav
•	Blood_gutter font : http://www.1001freefonts.com/d/1158/blood_gutter_2000.zip
•	Open Door sound: http://www.freesound.org/people/skyumori/sounds/104532/download/104532__skyumori__door-open-01.wav
