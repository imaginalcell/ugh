using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Selection : MonoBehaviour {

    public Button back;
    public Button soul;
    public Button heart;

    public GameObject player;
    
	// Use this for initialization
	void Start ()
    {
        back = back.GetComponent<Button>();
        soul = soul.GetComponent<Button>();
        heart = heart.GetComponent<Button>();
	}
	
    public void backButton()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void mageButton()
    {
        //some how load game with mage settings
        SceneManager.LoadScene("things");
    }

    public void warriorButton()
    {
        //some how load game with warrior settings
        SceneManager.LoadScene("ThingsDup");
    }
}
