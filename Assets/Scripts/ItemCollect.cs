using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour {
	[SerializeField] private string itemName;
	
	void OnTriggerEnter2D (Collider2D other) {
		Debug.Log ("Object collected:" + itemName);
		Destroy (this.gameObject);
	}
}
