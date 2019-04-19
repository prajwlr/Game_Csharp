using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscorescript : MonoBehaviour
{
    public static int hsval=0;
    Text hstxt;
    // Start is called before the first frame update
    void Start()
    {
        hsval = PlayerPrefs.GetInt("Highscore");
        hstxt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        hstxt.text = "Highscore : "+(PlayerPrefs.GetInt("Highscore")).ToString();
    }
}
