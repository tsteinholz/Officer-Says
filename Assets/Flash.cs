using UnityEngine;
using System.Collections;

public class Flash : MonoBehaviour {

	public Light red;
	public Light blue;
	public float rate;

	private bool running;

	// Use this for initialization
	void Start () {
		red.intensity = 0;
		blue.intensity = 0;
		running = false;
//		Debug.Log ("start");
	}
	
	// Update is called once per frame
	void Update () {
		if (!running) {
			StartCoroutine ("FlashCycle");
		}
	}

	IEnumerator FlashCycle() {
		running = true;
//		Debug.Log ("Red High");
		red.intensity = 5;
		yield return new WaitForSeconds (rate);
//		Debug.Log ("Red Low");
//		Debug.Log ("Blue High");
		red.intensity = 0;
		blue.intensity = 5;
		yield return new WaitForSeconds (rate);
//		Debug.Log ("Blue Low");
		blue.intensity = 0;
		running = false;
	}
}
