using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {
	public float speed = 0.1f;
	public Rigidbody2D playerRigidbody;

	public bool moveLeft;
	public bool moveRight;

	void Start() {
		playerRigidbody = GetComponent<Rigidbody2D> ();
	}

	void Update() {
		if (moveLeft && !moveRight) {
			playerRigidbody.AddForce (Vector2.left * speed);
		}

		if (moveRight && !moveLeft) {
			playerRigidbody.AddForce (Vector2.right * speed);
		}

	}

	public void MoveLeft() {
		moveLeft = true;
	}

	public void StopLeft() {
		moveLeft = false;
	}

	public void MoveRight() {
		moveRight = true;
	}

	public void StopRight() { 
		moveRight = false;
	}
}
