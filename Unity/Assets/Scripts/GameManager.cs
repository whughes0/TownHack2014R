using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject spawnedObject;

	// Use this for initialization
	void Start () {
		StartCoroutine (spawn());
	}
	IEnumerator spawn(){
		for (int i = 0; i <10; i++) {
			Instantiate (spawnedObject);
			yield return new WaitForSeconds (1);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
