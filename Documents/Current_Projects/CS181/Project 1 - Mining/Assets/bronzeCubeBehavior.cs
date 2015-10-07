using UnityEngine;
using System.Collections;

public class bronzeCubeBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnMouseDown () {
		Destroy(gameObject);
		gameController.bronzeOreCt--;
		gameController.bronzeScore++;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
