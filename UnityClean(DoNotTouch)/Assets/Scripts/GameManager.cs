using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject spawnedObject;
	public int spawnSpeed = 10;

	public int GAME_SCORE = 0;

	private int tick = 0;

	// Use this for initialization
	void Start () {
		StartCoroutine (spawn());
	}
	IEnumerator spawn(){
		for (int i = 0; i <10; i++) {
			Instantiate (spawnedObject);
			yield return new WaitForSeconds (spawnSpeed);
		}
	}

	// Update is called once per frame
	void Update () {
		tick++;

		if (tick / 60 / 5 > 1 && spawnSpeed > 1) {
			tick -= (60 * 5);
			spawnSpeed--;
		}
	}
}
