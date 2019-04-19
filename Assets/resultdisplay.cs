using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class resultdisplay : MonoBehaviour
{
    TextMeshProUGUI displaytxt;
    // Start is called before the first frame update
    void Start()
    {
        displaytxt = GetComponent<TextMeshProUGUI>();
        displaytxt.text = "Your Score : " + (PlayerPrefs.GetInt("Displayscore")).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartbutton(){
    	 SceneManager.LoadScene("Game");
    }

    public void mainmenubutton(){
    	SceneManager.LoadScene("Startmenu");
    }
}
