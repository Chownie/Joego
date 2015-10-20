using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovementManager : MonoBehaviour {
	[SerializeField]
	private List<Vector3> targetList = new List<Vector3>();
	private Vector3 lastPos;
	public int speed;
	// Update is called once per frame
	void Start () {
		lastPos = transform.position;
	}
	
	void Update () {
		if(targetList.Count > 0) {
			if(transform.position != lastPos+targetList[0]) {
				float step = speed * Time.deltaTime;
				transform.position = Vector3.MoveTowards(transform.position, lastPos+targetList[0], step);
			} else {
				targetList.RemoveAt(0);
				lastPos = transform.position;
			}
		}
	}
	
	public void NewTarget(Vector3 target) {
		targetList.Add(target);
	}
}