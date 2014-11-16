using UnityEngine;
using System.Collections;
using System;

public class FlyPhysics : MonoBehaviour {
	
	public Sprite[] sprites;
	public float framesPerSecond;

	private int updateCount;
	private Vector3 rotPoint;
	private Vector3 moveAs;
	
	// Use this for initialization
	void Start () {
		updateCount = 0;
		//rotPoint = new Vector3(0, 0, 0);
		//moveAs = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		//updateCount++;
		//Debug.Log ("         " + updateCount);
		if (updateCount == 30)
		{
			updateCount = 0;
			//updateCounterFred = 0;
			Debug.Log ("hit if statement: " + updateCount);
		}

		updateCount++;
		Debug.Log (updateCount);
		//System.Console.Write(updateCount);

		//holdAngle = transform.eulerAngles;
		//holdAngle.x = 0;
		//holdAngle.y = 0;
		//holdAngle.z = 0;


		//double test = Math.Asin((double) updateCount);
		//Debug.Log (test);

		//transform.position += moveAs;





		//transform.eulerAngles = holdAngle;
	}
}
