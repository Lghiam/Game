using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {
    //https://www.youtube.com/watch?v=4R_AdDK25kQ&t=0s&list=PLc7tnylBiuaRYIrc7uNprgDjhopB0RxOe&index=3 This was used to create an elevator
    private Vector3 posA;

	private Vector3 posB;

	private Vector3 nexPos;

	[SerializeField]
	private float speed;

	[SerializeField]
	private Transform childTransform;

	[SerializeField]
	private Transform transformB;

	// Use this for initialization
	void Start () {

		posA = childTransform.localPosition;
		posB = transformB.localPosition;
		nexPos = posB;
	}

	private void Move() {
		childTransform.localPosition = Vector3.MoveTowards (childTransform.localPosition, nexPos, speed * Time.deltaTime);
	
		if (Vector3.Distance (childTransform.localPosition, nexPos) <= 0.1) {
			ChangeDesitination ();
		}
	}
	// Update is called once per frame
	void Update () {
		Move ();
	}

	private void ChangeDesitination () {
		nexPos = nexPos != posA ? posA : posB;
	}
}
