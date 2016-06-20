using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public Canvas pauseMenu;

    public Button resume;
    public Button mainMenu;
    public Button exit;

	// Use this for initialization
	void Start ()
    {
        pauseMenu.enabled = false;
        pauseMenu = pauseMenu.GetComponent<Canvas>();
        resume = resume.GetComponent<Button>();
        mainMenu = mainMenu.GetComponent<Button>();
        exit = exit.GetComponent<Button>();
	}

	void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            pauseMenu.enabled = true;
            Time.timeScale = 0;
        }
    }

    public void clickResume()
    {
        pauseMenu.enabled = false;
        Time.timeScale = 1;
    }
	
    public void clickMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void clickExit()
    {
        Application.Quit();
    }
	
}
