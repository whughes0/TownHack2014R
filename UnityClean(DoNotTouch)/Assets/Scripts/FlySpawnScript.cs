using UnityEngine;
using System.Collections;

public class FlySpawnScript : MonoBehaviour {
	private Vector3 temp;
	private	Camera[] cameras;
	private Vector3 camPos;
	private Camera mainCam;

	// Use this for initialization
	void Start () {
		cameras = Camera.allCameras;
		foreach (Camera cam in cameras){
			if(cam.name.Equals("Main Camera")){
				mainCam = cam;
			}
		}
		camPos = mainCam.transform.position;
		temp = UnityEngine.Random.insideUnitSphere;
	
		temp *= 5;
		temp += camPos;

		transform.position = temp;
	}


}
