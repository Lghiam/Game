using UnityEngine;
using System.Collections;
public class CheckpointController : MonoBehaviour {
	public Sprite flagYellow1;
	public Sprite flagGreen1;
	private SpriteRenderer checkpointSpriteRenderer;
	public bool checkpointReached;
	// Use this for initialization
	void Start () {
		checkpointSpriteRenderer = GetComponent<SpriteRenderer> ();
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			checkpointSpriteRenderer.sprite = flagGreen1;
			checkpointReached = true;
		}
	}
}