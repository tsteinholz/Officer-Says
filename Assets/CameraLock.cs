using UnityEngine;
using System.Collections;

public class CameraLock : MonoBehaviour {

	public float min;
	public float max;

	Transform trans;

	void Start () {
		trans = GetComponent<Transform> ();
	}

	void LateUpdate () {
		//if (trans.transform.position.y < min) {
		//	trans.transform.position.y = min;
		//} else if (trans.transform.position.y > max) {
		//	trans.transform.position.y = max;
		//}
	}
}
