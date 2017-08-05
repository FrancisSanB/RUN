using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public Canvas mainCanvas;
	public RectTransform exitPanel;
	public Canvas biomeCanvas;
	public Button biome;
	public Button quit;
    public GameObject creditsCanvas;

	// Use this for initialization
	void Start()
    {
        biomeCanvas.gameObject.SetActive(false);
    }
	
	public void QuitPress() {
        exitPanel.gameObject.SetActive(true);
	}

    public void ConfirmQuit()
    {
        Application.Quit();
    }

    public void CloseQuitPanel()
    {
        exitPanel.gameObject.SetActive(false);
    }

	public void BiomePress() {
		biomeCanvas.gameObject.SetActive(true);
		mainCanvas.gameObject.SetActive(false);
	}

	public void LoadSceneNumber(int number)
    {
        SceneManager.LoadScene(number);
        Debug.Log("Loaded scene number: " + number);
    }

	public void StorePress() {
		//TODO make a store, in another update

	}

	public void CreditsPress() {
        //TODO make a credits in the before release MAKE SURE IT INCLUDES THE FONT
        //dafont.com/lemon-milk.font 

        // Make main menu invisible first
        mainCanvas.gameObject.SetActive(false);
        creditsCanvas.SetActive(true);
	}

    public void ExitCredits()
    {
        creditsCanvas.SetActive(false);
        mainCanvas.gameObject.SetActive(true);
    }
}