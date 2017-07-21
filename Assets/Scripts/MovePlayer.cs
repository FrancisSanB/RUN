using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum MovementType{Mobile, Desktop}

public class MovePlayer : MonoBehaviour {
	public float speed = 50f;
    public float jumpSpeed = 3f;

    public Rigidbody2D playerRigidbody;

    bool moveLeft;
	bool moveRight;

    MovementType type;

	void Start() {
		playerRigidbody = GetComponent<Rigidbody2D> ();
	    
        type = Application.isMobilePlatform ? MovementType.Mobile : MovementType.Desktop;
    }

	void Update() {

        /*switch (type) {
            
            case MovementType.Mobile:
                // TODO make mobile movement less shitty
                if (moveLeft && !moveRight)
                {
                    playerRigidbody.AddForce(Vector2.left * speed);
                }

                if (moveRight && !moveLeft)
                {
                    playerRigidbody.AddForce(Vector2.right * speed);
                }
                break;
            
            case MovementType.Desktop:*/
       	playerRigidbody.AddForce(Vector2.right * speed * Input.GetAxis("Horizontal") * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
		playerRigidbody.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
        }
		//break;
        //}



	}

	public void MoveLeft() {
		moveLeft = true;
		Debug.Log ("MOVING LEFT");
	}

	public void StopLeft() {
		moveLeft = false;
		Debug.Log ("STOP LEFT");
	}

	public void MoveRight() {
		moveRight = true;
		Debug.Log ("MOVE RIGHT");
	}

	public void StopRight() { 
		moveRight = false;
		Debug.Log ("STOP RIGHT");
	}
}
