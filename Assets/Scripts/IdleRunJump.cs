using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleRunJump : MonoBehaviour {
	Animator animator;
	
	void Start () {
		animator=GetComponent<Animator>();
	}
	
	void Update () {
		if(animator){
			AnimatorStateInfo stateInfo
			=animator.GetCurrentAnimatorStateInfo(0);

			if(stateInfo.IsName("Base Layer.Run")){
				if(Input.GetButton("Fire1")){
					animator.SetBool("Jump",true);
				}else{
					animator.SetBool("Jump",false);
				}
			}
			
			if(Input.GetButtonDown("Fire2")){
				animator.SetBool("WaveBool", !animator.GetBool("WaveBool"));
			}

			float h=Input.GetAxis("Horizontal");
            animator.SetFloat("Direction", h);
			

			float v=Input.GetAxis("Vertical");
			animator.SetFloat("Speed",v);
		}
	}
}
