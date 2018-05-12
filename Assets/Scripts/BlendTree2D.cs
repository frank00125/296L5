using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendTree2D : MonoBehaviour {

	Animator animator;
	float valX = 1.5f;
	float valY = 1.5f;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal") * 1.5f;
		float v = Input.GetAxis("Vertical") * 1.5f;

		animator.SetFloat("ValX", h);
		animator.SetFloat("ValY", v);
	}
}
