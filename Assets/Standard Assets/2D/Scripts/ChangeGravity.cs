﻿using UnityEngine;
using System.Collections;

public class ChangeGravity : MonoBehaviour {

    public float gravity;
    private GameObject player;
    bool pickup;

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (pickup)
            {
                player.GetComponent<Rigidbody2D>().gravityScale = gravity;
                this.GetComponent<AudioSource>().Play();
                Destroy(this.gameObject.GetComponent<BoxCollider2D>());
                Destroy(this.gameObject.GetComponent<SpriteRenderer>());
                Debug.Log("gravity changed to: " + gravity);
            }
        }
            
    }
    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        pickup = Input.GetButton("Pickup");
    }
}
