using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restartinggamescript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(){
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    	if(PlayerPrefs.GetInt("Highscore")<Scorescript.scoreval)PlayerPrefs.SetInt("Highscore", Scorescript.scoreval);
    }
}
