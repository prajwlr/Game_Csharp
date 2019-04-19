using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shieldrotatora : MonoBehaviour
{
    public float speed = 20f;
    // Start is called before the first frame update
    float movement=0f;
    float movement_sign=0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        if(movement>0f)movement_sign=-1f;
        else if(movement<0f)movement_sign=1f;
        else movement_sign=0f;
        
    }

    private void FixedUpdate(){
        transform.RotateAround(Vector3.zero, Vector3.forward, movement_sign * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col){
        Destroy(col.gameObject);
        Scorescript.scoreval += 1;
    }
}
