using UnityEngine;
using System.Collections;
using System;

public class FlyMovement : MonoBehaviour {

	public Sprite[] sprites;
	public float framesPerSecond;
	private SpriteRenderer spriteRenderer;

	private Vector3 prevPos;
	private Vector3 origin;
	protected int yDir;
	protected int xDir;
	protected int zDir;
	private Vector3 holdAngle;
	private int revSpeed;
	private int updateCount;
	private Vector3 rotPoint;

	// Use this for initialization
	void Start () {
		spriteRenderer = renderer as SpriteRenderer;
		origin = new Vector3(1, 1, 1);
		revSpeed = 180;

		prevPos = transform.position;

		xDir = 1;
		yDir = 1;
		zDir = 1;

		updateCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		updateCount++;

		//prevPos = transform.position;

		//BoundXMotion(2, 5);
		//BoundYMotion(2, 5);
		//BoundZMotion(2, 5);

		holdAngle = transform.eulerAngles;
		holdAngle.x = 0;
		//holdAngle.y = 0;
		//holdAngle.z = 0;
		//holdAngle.x = transform.eulerAngles.x;
		//holdAngle.y = transform.eulerAngles.y;
		//holdAngle.z = transform.eulerAngles.z;

		//transform.RotateAround (origin, new Vector3(1, 0, 1), revSpeed * Time.deltaTime);

		//transform.RotateAround (origin, Vector3.up, 180 * Time.deltaTime);
		//transform.RotateAround (origin, new Vector3(1,1,1), 180 * Time.deltaTime);
		
		//transform.position += vertDir * Vector3.up * Time.deltaTime;

		//transform.position += xDir * new Vector3(1, 0, 0) * Time.deltaTime;
		//transform.position += yDir * new Vector3(0, 1, 0) * Time.deltaTime;
		//transform.position += zDir * new Vector3(0, 0, 1) * Time.deltaTime;

		//holdAngle.x = transform.eulerAngles.x;
		//holdAngle.y = transform.eulerAngles.y;
		//holdAngle.z = transform.eulerAngles.z;
		transform.eulerAngles = holdAngle;
		
		//RandShiftVector(origin, true, true, true, -0.03f, 0.03f);
		
		/*
		if(updateCount % 60 == 0)
		{
			rotPoint = transform.position - GenRandVec(-1.0f, 1.0f);
			Debug.Log ("rot create: " + rotPoint);
		}
		else if (updateCount % 60 < 10)
		{
			Turn(rotPoint);
			Debug.Log ("in turn: " + rotPoint);
		}

		updateCount %= 60;
		*/

		//shiftOrigin(origin);

	}

	private void Turn(Vector3 refVec)
	{
		transform.RotateAround(refVec, Vector3.up, revSpeed * Time.deltaTime);
	}

	private void BoundXMotion(float lower, float upper)
	{
		if (transform.position.x > upper)
		{
			xDir = -1;
		}
		if (transform.position.x < lower)
		{
			xDir = 1;
		}
	}

	private void BoundYMotion(float lower, float upper)
	{
		if (transform.position.y > upper)
		{
			yDir = -1;
		}
		if (transform.position.y < lower)
		{
			yDir = 1;
		}
	}

	private void BoundZMotion(float lower, float upper)
	{
		if (transform.position.z > upper)
		{
			zDir = -1;
		}
		if (transform.position.z < lower)
		{
			zDir = 1;
		}
	}

	private void RandShiftX(Vector3 vec, float minDelta, float maxDelta)
	{
		vec.x = RandShiftPoint(minDelta, maxDelta);
		Debug.Log("x: " + vec);
	}

	private void RandShiftY(Vector3 vec, float minDelta, float maxDelta)
	{
		vec.y = RandShiftPoint(minDelta, maxDelta);
		Debug.Log("y: " + vec);
	}

	private void RandShiftZ(Vector3 vec, float minDelta, float maxDelta)
	{
		vec.z = RandShiftPoint(minDelta, maxDelta);
		Debug.Log("z: " + vec);
	}
	/*
	private void RandShiftVector(Vector3 vec, bool x, bool y, bool z, float minDelta, float maxDelta)
	{
		if (x)
		{
			RandShiftX(vec, minDelta, maxDelta);
		}
		if (y)
		{
			RandShiftY(vec, minDelta, maxDelta);
		}
		if (z)
		{
			RandShiftZ(vec, minDelta, maxDelta);
		}

		Debug.Log ("Vector: " + vec);
	}*/

	/*
	private void RandShiftVectorAll(Vector3 vec, float minDelta, float maxDelta)
	{
		RandShiftVector(vec, true, true, true, minDelta, maxDelta);

		Debug.Log ("All: " + vec);
	}*/

	private Vector3 GenRandVec(float minDelta, float maxDelta)
	{
		Vector3 vec = new Vector3();
		//RandShiftVectorAll(vec, minDelta, maxDelta);
		RandShiftX(vec, minDelta, maxDelta);
		RandShiftY(vec, minDelta, maxDelta);
		RandShiftZ(vec, minDelta, maxDelta);
		Debug.Log ("GenRandVec: " + vec);
		return vec;
	}

	private float RandShiftPoint(float minDelta, float maxDelta)
	{
		return UnityEngine.Random.Range(minDelta, maxDelta);
	}

	private int RandPosOrNeg()
	{
		int posneg;
		float random = UnityEngine.Random.Range(-1.0f, 1.0f);
		if (random < 0)
			posneg = -1;
		else
			posneg = 1;
		return posneg;
	}

	/*
	private bool onPath(Vector3 origin, Vector3 path, Vector3 move)
	{
		bool onPath = false;

		return onPath;
	}*/
}
