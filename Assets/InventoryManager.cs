using UnityEngine;
using System.Collections;

public class InventoryManager : MonoBehaviour {
	[SerializeField]
	private GameObject available;
	[SerializeField]
	private GameObject holding;
	void OnTriggerEnter(Collider collision) {
		available = collision.gameObject;
	}

	void OnTriggerExit(Collider collision) {
		available = null;
	}
	
	public void PickUp() {
		Debug.Log("Pick up is being called!");
		if(!holding) {
			holding = available;
			available = null;
			holding.transform.parent = gameObject.transform;
			holding.GetComponent<PickUpItemEffect>().ToggleHeld();
		}
	}
	
	public void Drop() {
		Debug.Log("Drop is being called!");
		holding.GetComponent<PickUpItemEffect>().ToggleHeld();
		holding.transform.parent = null;
	}
}