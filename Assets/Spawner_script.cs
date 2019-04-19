using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_script : MonoBehaviour
{
    public GameObject bullet;
    Vector2 spawn_ordinates;
    float spawn_rate=1f;
    float spawn_time=0f;
    float randx;
    float randy;
    float randside;

    // Start is called before the first frame update
    void Start()
    {
        spawn_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>spawn_time){
        	spawn_time = spawn_time + spawn_rate;
        	randside = Random.Range(0f,4f);
            randx = Random.Range(-12f,12f);
            randy = Random.Range(-6f,6f);

            if(randside<1f){
                spawn_ordinates = new Vector2(-12f,randy);
            }else if(randside<2f){
                spawn_ordinates = new Vector2(randx,-6f);
            }else if(randside<3f){
                spawn_ordinates = new Vector2(12f,randy);
            }else if(randside<4f){
                spawn_ordinates = new Vector2(randx,6f);
            }
            Instantiate(bullet,spawn_ordinates,Quaternion.identity);
        }
    }
}
