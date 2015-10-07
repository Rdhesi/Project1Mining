using UnityEngine;
using System.Collections;

public class silverCubeBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnMouseDown () {
		Destroy(gameObject);
		gameController.silverOreCt--;
		gameController.silverScore+=10;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
