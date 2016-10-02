using UnityEngine;
using System.Collections;

enum difficulty
{
	DIFFICULTY_EASY,
	DIFFICULTY_HARD,
}

public class Meta : MonoBehaviour {

	[Range(0,1)]
	public int difficulty;

	void Start () {
		difficulty = Random.Range (0, 1);
	}
}