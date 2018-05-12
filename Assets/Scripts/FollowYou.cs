using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowYou : MonoBehaviour {

	public Transform target;
	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(animator && target){
			if(Vector3.Distance(target.position, animator.rootPosition) > 2){
				animator.SetFloat("Speed", 1);
				Vector3 currentDirection = animator.rootRotation * Vector3.forward;
				Vector3 wantedDirection = (target.position - animator.rootPosition).normalized;

				if(Vector3.Dot(currentDirection, wantedDirection) > 0){
					animator.SetFloat("Direction", Vector3.Cross(currentDirection, wantedDirection).y);
				}
				else{
					animator.SetFloat("Direction", (Vector3.Cross(currentDirection, wantedDirection).y > 0) ? 1 : -1);
				}
			}
			else{
				animator.SetFloat("Speed", 0);
			}
		}
	}
}
