using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shieldrotatorb : MonoBehaviour
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
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z=0f;
        
            movement = touchPosition.x;
            //movement = Input.GetAxisRaw("Horizontal");
            if(movement>0f)movement_sign=-1f;
            else if(movement<0f)movement_sign=1f;
            else movement_sign=0f;
        }else{
            movement_sign=0f;
        }
    }

    private void FixedUpdate(){
        transform.RotateAround(Vector3.zero, Vector3.forward, movement_sign * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col){
        Destroy(col.gameObject);
        Scorescript.scoreval += 1;
    }
}
