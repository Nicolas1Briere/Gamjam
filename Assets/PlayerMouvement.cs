using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{

	public float speed = 115f;
    private Vector2 playerpos;
    private Rigidbody2D player_rb;

    // Start is called before the first frame update
    void Start()
    {
        player_rb = GetComponent<Rigidbody2D>();
    }

    void Update () {
		CheckKeys ();
	
	}

	void CheckKeys (){
	    player_rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.fixedDeltaTime, Input.GetAxisRaw("Vertical") * speed * Time.fixedDeltaTime);
	}

	void OnCollisionEnter2D(Collision2D collision)
    {
        player_rb.velocity = Vector2.zero;
    }
}
