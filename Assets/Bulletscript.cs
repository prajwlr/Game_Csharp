using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletscript : MonoBehaviour
{
	private Rigidbody2D rb;
	public float vel=20f;
	float velx;
	float vely;
	float posx;
	float posy;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        posx = transform.position.x;
        posy = transform.position.y;
        if(posx<5f&&posx>-5f)vel=vel*0.5f;
        vely = -1*(vel)*((posy)/Mathf.Sqrt((posx*posx)+(posy*posy)));
        velx = -1*(vel)*((posx)/Mathf.Sqrt((posx*posx)+(posy*posy)));
        rb.velocity = new Vector2(velx,vely);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
