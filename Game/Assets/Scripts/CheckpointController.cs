using UnityEngine;
using System.Collections;
public class CheckpointController : MonoBehaviour {
    //https://www.youtube.com/watch?v=WUx3svZ3WB4
    //https://www.youtube.com/watch?v=udUNv5aEXIU&t=5s These 2 videos were used to create a checkpoint system *note* we were unable to implement this system in time
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