using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PickUpItemEffect : MonoBehaviour {
	private bool held;
	public int speed;
	public GameObject winCondition;
	// Use this for initialization
	void Start () {
		held = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(!held) {
			transform.Rotate((Vector3.up*speed) * Time.deltaTime);
		}
	}
	
	public void ToggleHeld() {
		held = !held;	
	}
	
    void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "goal") {
			winCondition.SetActive(true);
		}
    }
}
