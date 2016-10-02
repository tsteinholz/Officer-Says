/*using UnityEngine;
using System.Collections;

float timeRemaining=5;
public class HardTimer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeRemaining -= Time.deltaTime;
	}


	void OnGUI(){

		if (timeRemaining > 0) {
			GUI.Label (new Rect (100, 100, 200, 100), "Time Remaining: " + (int)timeRemaining);
		} else {
			GUI.Label(new Rect(100, 100, 100, 100), "Please proceed out of your vehicle.");

		}
}
*/