using UnityEngine;
using System.Collections;

public class spawnCube : MonoBehaviour {
    public GameObject cube;
    bool hasSpawned=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
      
        if (Time.time>5&&hasSpawned==false)
        {
            Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);
            hasSpawned = true;
        }
	}
}
