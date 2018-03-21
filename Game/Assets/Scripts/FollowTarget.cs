using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {

	//what is being followed
	public Transform target;

	//zeros out velocity
	Vector3 velocity = Vector3.zero;

	//time to follow target
	public float smoothTime = .15f;

	void FixedUpdate(){
		
		//target position
		Vector3 targetPos = target.position;

		//align camera and targets z position
		targetPos.z = transform.position.z;

		//camera transform position
		transform.position = Vector3.SmoothDamp (transform.position, targetPos, ref velocity, smoothTime);
	}
}
