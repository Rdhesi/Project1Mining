using UnityEngine;
using System.Collections;

public class goldCubeBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnMouseDown () {
		Destroy(gameObject);
		gameController.goldScore+=100;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
