using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public Canvas mainCanvas;
	public Canvas exitCanvas;
	public Canvas biomeCanvas;
	public Button biome;
	public Button quit;

	// Use this for initialization
	void Start () {
		mainCanvas = mainCanvas.GetComponent<Canvas> ();
		exitCanvas = exitCanvas.GetComponent<Canvas> ();
		biomeCanvas = biomeCanvas.GetComponent<Canvas> ();
		biome = biome.GetComponent<Button> ();
		quit = quit.GetComponent<Button> ();

		biomeCanvas.enabled = false;

	}
	
	public void quitPress() {
		//TODO exit pressing system, bring exit canvas

	}

	public void biomePress() {
		biomeCanvas.enabled = true;
		mainCanvas.enabled = false;
	}

	public void desertGame() {
		SceneManager.LoadScene (1);
		Debug.Log ("'tis loaded");

	}

	public void storePress() {
		//TODO make a store, in another update

	}

	public void creditsPress() {
		//TODO make a credits in the before release MAKE SURE IT INCLUDES THE FONT
		//dafont.com/lemon-milk.font 

	}
}