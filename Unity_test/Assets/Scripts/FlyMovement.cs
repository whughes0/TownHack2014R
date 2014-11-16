using UnityEngine;
using System.Collections;
using System;

public class FlyMovement : MonoBehaviour {
	
	public Sprite[] sprites;
	public float framesPerSecond;
	private SpriteRenderer spriteRenderer;
	private Vector3 origin;
	private Vector3 delta;
	private int radius;
	private int updateCount;
	private float downScale;
	private int vertDir;
	private int vertHold;
	private Vector3 holdAngle;
	
	// Use this for initialization
	void Start () {
		spriteRenderer = renderer as SpriteRenderer;
		origin = new Vector3(1, 1, 1);
		//origin = transform.position - relativeInit;
		//relative = relativeInit;
		vertDir = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (transform.position.y > 5)
		{
			vertDir = -1;
		}
		if (transform.position.y < 2)
		{
			vertDir = 1;
		}
		
		holdAngle = transform.eulerAngles;
		transform.RotateAround (origin, Vector3.up, 180 * Time.deltaTime);
		transform.position += vertDir * Vector3.up * Time.deltaTime;
		transform.eulerAngles = holdAngle;
		
		origin.z += UnityEngine.Random.Range(-0.03f, 0.03f);
		
		//shiftOrigin(origin);
		
	}
	
	private void shiftOrigin(Vector3 origin)
	{
		origin.x = RandShiftPoint(origin.x, 2, 9);
		//origin.y = RandShiftPoint(origin.y, 0, 3);
		//origin.z = RandShiftPoint(origin.z, 0, 3);
	}
	
	private float RandShiftPoint(float orig, float minDelta, float maxDelta)
	{
		//float random = Random.Range((float) minDelta, (float) maxDelta);
		//int random = (int) Random.Range((float) minDelta, (float) maxDelta);
		float random = UnityEngine.Random.Range(minDelta, maxDelta);
		
		orig += random;//RandPosOrNeg() * random;
		
		return orig;
	}
	
	private int RandPosOrNeg()
	{
		int posneg = (int) UnityEngine.Random.Range(0, 1.99f);
		if (posneg == 0) { posneg -= 1; }
		return posneg;
	}
	
	private bool onPath(Vector3 origin, Vector3 path, Vector3 move)
	{
		bool onPath = false;
		
		return onPath;
	}
}
