using UnityEngine;
using System.Collections;

public class PrototypeMove : MonoBehaviour {
	public float speed;

	void Start() {
		Debug.Log ("this is working");

	}

	void Update() {
		float deltax = Input.GetAxis ("Horizontal") * speed;
		transform.Translate (deltax, 0, 0, Space.World);
		transform.Rotate (0, 0, 0);
		Debug.Log ("umm stuff " + deltax);

	}

}
