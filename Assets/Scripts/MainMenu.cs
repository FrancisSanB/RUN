using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public Canvas mainCanvas;
	public Canvas exitCanvas;
	public Button desert;
	public Button exit;

	// Use this for initialization
	void Start () {
		mainCanvas = mainCanvas.GetComponent<Canvas> ();
		exitCanvas = exitCanvas.GetComponent<Canvas> ();
		desert = desert.GetComponent<Button> ();
		exit = exit.GetComponent<Button> ();

	}
	
	public void exitPress() {
		//TODO exit pressing system, bring exit canvas

	}

	public void desertGame() {
		SceneManager.LoadScene (1);

	}

	public void storePress() {
		//TODO make a store, in another update

	}

	public void creditsPress() {
		//TODO make a credits in the before release MAKE SURE IT INCLUDES THE FONT
		//dafont.com/lemon-milk.font 

	}
}