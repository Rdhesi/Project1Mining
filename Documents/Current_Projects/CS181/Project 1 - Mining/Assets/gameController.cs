using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {
	public GameObject bronzeOre;
	public GameObject silverOre;
	public GameObject goldOre;
	double createBronzeTime=3.0;
	double startTime=0.0;
	public static int bronzeOreCt=0;
	public static int silverOreCt=0;
	bool goldOreCt=false;

	/*public static GUIText goldText;
	public static GUIText silverText;
	public static GUIText bronzeText;
	public static GUIText totalScore;*/
	public static int bronzeScore=0;
	public static int silverScore=0;
	public static int goldScore=0;
	// Use this for initialization
	void Start () {
		startTime += createBronzeTime;

	}
	
	// Update is called once per frame
	void Update () {
		//updateScore ();
		if (Time.time > startTime && bronzeOreCt < 4) {
			int loc1 = Random.Range (-5, 5);
			int loc2 = Random.Range (-4, 5);
			Instantiate (bronzeOre, new Vector3 (loc1, loc2, 0), Quaternion.identity);
			startTime += createBronzeTime;
			bronzeOreCt++;
			goldOreCt = false;


		}
		if (Time.time > startTime && bronzeOreCt >= 4) {
			int loc1 = Random.Range (-5, 5);
			int loc2 = Random.Range (-4, 5);
			Instantiate (silverOre, new Vector3 (loc1, loc2, 0), Quaternion.identity);
			startTime += createBronzeTime;
			silverOreCt++;
			goldOreCt = false;
		
		}
		if (bronzeOreCt == 2 && silverOreCt == 2 && goldOreCt == false) {
			int loc1 = Random.Range (-5, 5);
			int loc2 = Random.Range (-4, 5);
			Instantiate (goldOre, new Vector3 (loc1, loc2, 0), Quaternion.identity);
			startTime += createBronzeTime;
			goldOreCt = true;
		}
		print ("Gold Score "+goldScore + " ");
		print ("Silver Score "+silverScore + " ");
		print ("Bronze Score "+bronzeScore + " ");
		print ("total Score "+(goldScore+silverScore+bronzeScore));

	}
		/*void updateScore()
		{
			goldText.text = "Gold Score "+goldScore;
			silverText.text = "Silver Score "+silverScore;
			bronzeText.text= "Bronze Score "+bronzeScore;
			totalScore.text = "total Score "+(goldScore+silverScore+bronzeScore);
		}*/
	
}
