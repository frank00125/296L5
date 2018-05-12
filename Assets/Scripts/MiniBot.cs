using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBot : MonoBehaviour {

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		animator.SetFloat("Speed", h*h + v*v);

		animator.SetFloat("Direction", Mathf.Atan2(h, v) * 180.0f / Mathf.PI);

		Rigidbody rb = GetComponent<Rigidbody>();
		if(rb){
			Vector3 speed = rb.velocity;
			speed.x = 4 * h;
			speed.z = 4 * v;
			
		}
	}
}
