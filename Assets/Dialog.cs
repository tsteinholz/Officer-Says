using UnityEngine;
using System.Collections;

public class Dialog : MonoBehaviour {

	Meta curr_meta;

	// Use this for initialization
	void Start () {
		curr_meta = GetComponent<Meta>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

//	string GetDialog(string key) {
		//string mode = (bool) curr_meta.difficulty ? "easy" : "hard";
//	}
}
