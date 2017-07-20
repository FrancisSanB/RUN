using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour {
	[SerializeField] private string itemName;
	
	void OnTriggerEnter (Collider2D other) {			//TODO FIX THIS ASAP
		Destroy (this.gameObject);
	}
}
