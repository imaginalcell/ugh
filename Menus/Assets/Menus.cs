using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menus : MonoBehaviour
{

    public Canvas subMenu;
    public Button toPlay;
    public Button toExit;

    // Use this for initialization
    void Start()
    {
        subMenu.enabled = false;
        subMenu = subMenu.GetComponent<Canvas>();

        toExit = toExit.GetComponent<Button>();
    }

    public void StartGame()
    {

    }

    public void QuitPanal()
    {
        subMenu.enabled = true;
        toPlay.enabled = false;
        toExit.enabled = false;
    }

    public void clickNo()
    {
        subMenu.enabled = false;
        toPlay.enabled = true;
        toExit.enabled = true;
    }

    public void clickYes()
    {
        Application.Quit();
    }
}
