using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject spawnedObject;
	public int spawnSpeed = 10;

	private int gameScore = 0;

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
			this.incrementScore();
		}
	}

	public void incrementScore() {
		this.gameScore++;
		this.gameObject.GetComponentInChildren<GUIText> ().text = "Score : " + gameScore;
	}
	public void decrementScore() {
		this.gameScore--;
		this.gameObject.GetComponentInChildren<GUIText> ().text = "Score : " + gameScore;
	}
}
