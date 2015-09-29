using UnityEngine;
using System.Collections;

public class spawnOre : MonoBehaviour {
    public GameObject bronzeOre;
	public GameObject silverOre;
	double createBronzeTime=3.0;
	double switchToSilverTime=10.0;
	double stopSpawningTime=16.0;
	double startTime=0.0;
	// Use this for initialization
	void Start () {
		startTime += createBronzeTime;

		createBronzeTime=Random.Range(1,5);
		switchToSilverTime=Random.Range(7,20);
		stopSpawningTime=Random.Range(20,30);
	}
	
	// Update is called once per frame
	void Update () {
      
		if (Time.time>startTime&&Time.time<switchToSilverTime)
        {
			int loc1= Random.Range(-10,11);
			int loc2= Random.Range(-10,11);
			Instantiate(bronzeOre, new Vector3(loc1,loc2,0), Quaternion.identity);
			startTime += createBronzeTime;


        }
		if (Time.time>startTime&&Time.time>=switchToSilverTime&&Time.time<stopSpawningTime)
		{
			int loc1= Random.Range(-10,11);
			int loc2= Random.Range(-10,11);
			Instantiate(silverOre, new Vector3(loc1,loc2,0), Quaternion.identity);
			startTime += createBronzeTime;

		}
	}
}
