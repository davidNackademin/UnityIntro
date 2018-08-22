using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSquare : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Rigidbody2D body = GetComponent<Rigidbody2D>();

        body.AddForce(new Vector2(-0.3f, 0.7f) * 500f);
	}
	
}
