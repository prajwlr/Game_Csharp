using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorescript : MonoBehaviour
{
    public static int scoreval=0;
    Text scoretxt;

    // Start is called before the first frame update
    void Start()
    {
        scoreval=0;
        scoretxt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoretxt.text = "Score : " + scoreval;
    }
}
