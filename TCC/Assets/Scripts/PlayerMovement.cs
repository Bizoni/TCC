using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D body;
    Animator anim;

	// Use this for initialization
	void Start () {

        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

		
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (movement != Vector2.zero)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("inputX", movement.x);
            anim.SetFloat("inputY", movement.y);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        body.MovePosition(body.position + movement * Time.deltaTime);
	}
}
