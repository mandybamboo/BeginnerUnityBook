using System.Collections; // standard aka automatically added to the scene
using System.Collections.Generic; //standard
using UnityEngine; //standard
using UnityEngine.UI; //Add this!  It gives access to Canvas items, like Text and Image
using UnityEngine.SceneManagement; //Add this! It gives access to changing scenes

/*
 * Pro-Tip:
 * Always comment your code!!!
 * Commenting gives better context to what your code was meant for.
 * We'll cover this in more detail in later tutorials, but for now use all the comments below as an example of what thorough explaination is.
*/

/// <summary>
/// Intro manager.
/// This will manage our first Scene of our Comic Book
/// </summary>
public class IntroManager : MonoBehaviour
{

    #region Variables
    //Your first data type, an integer.
    //We are declaring it, by giving it a data type and a name.  Then we assign it by making it equal to '0', then closing that line with a semi-colon";"
    //this will be incremented each time we press our button in the book to manage what string (strings are also a data type) that is visible.
    int textCount = 0;

    //This is where our text will go that tells our story. 
    //Making it Public gives us access to it in the Unity Editor.
    [Tooltip("Connect this to the text box in the canvas")]
    public Text introTxt;

    //this now gives us a drop down list of scenes that we add to the enum list. We can select it based on the next scene to be loaded
    public ProjectEnums.SceneNames nextScene;

    //the '[]' denotes that this is a string array, we name it whatever we want and as always close it with ";"
	public string[] sceneText;

	#endregion

	#region Methods
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
        SceneManager.LoadScene(nextScene.ToString());//This needs to be converted to a string, so we add the ToString() to our variable to pass it as a string to the LoadScene method.

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
        if (textCount < sceneText.Length)//the '<' here means "less than", so checks to see if the integer is less than the number of strings in our array. 
        {
            introTxt.text = sceneText[textCount];//now we can drop the textCount in the brackets and the sceneText array will return the value of the string for which ever the current count we are at
            //for Example: if our textCount is at 0, then sceneText will return the same as if we did sceneText[0], thus returning that string we assigned in place 0.
        }
        else // this is a catch all, meaning if textCount never matches any of the above checks, then it will default to this one.  It's kinda a safety net, so that our app does something.
        {
            SwitchScene();
        }//this curly bracket closes our if statement

        //Here we increment our integer by using the operator "++" and of course close it with our Semi-Colon ";"!
        textCount++;

    }//this curly bracket closes our ChangeText Statement

    #endregion
}//This curly bracket closes our IntroManager class
