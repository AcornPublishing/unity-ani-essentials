//--------------------------------------------
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//--------------------------------------------
public class ShowMessage : MonoBehaviour 
{
	//Reference to GUI canvas to show on event
	public Canvas UICanvas = null;

	//Function to be called from an Animation Event
	void ShowWelcomeMessage()
	{
		//Enable canvas to show message
		UICanvas.gameObject.SetActive(true);
	}
}
//--------------------------------------------