using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Add this!  It gives access to Canvas items, like Text and Image
using UnityEngine.SceneManagement; //Add this! It gives access to changing scenes


public class EndingManager : MonoBehaviour {

	//Your first data type, an integer.
	//We are declaring it, by giving it a data type and a name.  Then we assign it by making it equal to '0', then closing that line with a semi-colon";"
	//this will be incremented each time we press our button in the book to manage what string (strings are also a data type) that is visible.
	int textCount = 0;

	//This is where our text will go that tells our story. 
	//Making it Public gives us access to it in the Unity Editor.
	[Tooltip("Connect this to the text box in the canvas")]
	public Text introTxt;

	// Use this for initialization
	void Start()
	{
		//usually we would put anything here that would need to happen at the start of the scipt.
		//There is also an Awake function you can use too.
	}


	/// <summary>
	/// Switches the scene.
	/// This will change to the next scene when we are done clicking thru the text in this scene.
	/// </summary>
	void SwitchScene()
	{
		//SceneManager is a behavior in Unity that we gained access to by including a reference to it on line 5 above.
		//If you comment out line 5 by putting "//" infront of it, there will be a compiler error pointing to the line below and our scene will not play.
		SceneManager.LoadScene("");

	}

	/// <summary>
	/// Changes the text. --- Naming the functions as literally as possible helps you understand what you originally meant for the code.
	/// This is a "Public" method that we will connect to our Button. If it were not public, then we would not have access to it in the Unity Interface.
	/// Every method must have "()", which declares the method and curley brackets to enclose the functions.
	/// In later tutorials, you'll learn that you can pass varialbles thru these, return data types with these, and all kinds of exciting things!
	/// </summary>
	public void ChangeText()
	{
		//This is an If Statement.  Notice how clean it looks with each curly bracket on it's own line and properly indented.
		if (textCount == 0)//the '==' here means "Equals", so checks to see if the integer is equal to the number to the right. The "==" is an operator, there are several types we will go over in the future.
		{
			introTxt.text = "Hello World, this is my first string";
		}
		else if (textCount == 1)//we can add a few of these, but in most cases, if we have a lot of these, we can actually turn it to a Switch statement instead. We'll go over those in the future
		{
			introTxt.text = "Strings are data types. This data type can hold different characters, letters or numbers.";
		}
		else // this is a catch all, meaning if textCount never matches any of the above checks, then it will default to this one.  It's kinda a safety net, so that our app does something.
		{
			SwitchScene();
		}//this curly bracket closes our if statement

		//Here we increment our integer by using the operator "++" and of course close it with our Semi-Colon ";"!
		textCount++;

	}//this curly bracket closes our ChangeText Statement

}//This curly bracket closes our IntroManager class


