using UnityEngine;
using System.Collections;

public class PlantBite : MonoBehaviour {

	public int velocityDown = 500;
	public int velocityUp = 50;

	private HingeJoint jawTop;
	private HingeJoint jawBottom;
	private JointMotor topMotor;
	private JointMotor bottomMotor;
	private bool isBiting;

	public void Start () {
		this.isBiting = false;
		HingeJoint[] hingeJoints = GetComponentsInChildren<HingeJoint>();
		foreach (HingeJoint joint in hingeJoints) {
			if(joint.name == "instance_0") {
				jawBottom = joint;
			} else if(joint.name == "instance_1") {
				jawTop = joint;
			}
		}

		topMotor = jawTop.motor;
		bottomMotor = jawBottom.motor;
	}

	public void Update () {
		if(this.isBiting)
		{
			if(topMotor.targetVelocity < 0) {
				if(jawTop.angle <= -39) {
					topMotor.targetVelocity = velocityUp;
					topMotor.force = 10;
				}
			}
			else if(topMotor.targetVelocity > 0) {
				if(jawTop.angle >= 0) {
					stopBite();
				}
			}

			if(bottomMotor.targetVelocity > 0) {
				if(jawBottom.angle >= 39) {
					bottomMotor.targetVelocity = -velocityUp;
					bottomMotor.force = 10;
				}
			}
			else if(bottomMotor.targetVelocity < 0) {
				if(jawBottom.angle <= 0) {
					stopBite();
				}
			}
		}
	}

	public void bite() {
		if(!this.isBiting)
		{
			Debug.Log("Chomp Chomp!");
			this.isBiting = true;
			//jawTop.rigidbody.freezeRotation = false;
			//jawBottom.rigidbody.freezeRotation = false;
		
			jawTop.useMotor = true;
			jawTop.useSpring = false;
			jawBottom.useMotor = true;
			jawBottom.useSpring = false;


			topMotor.targetVelocity = -velocityDown;
			Debug.Log(topMotor.targetVelocity);
			Debug.Log(jawTop.motor.targetVelocity);
			bottomMotor.targetVelocity = velocityDown;

			topMotor.force = 100;
			bottomMotor.force = 100;
		}
	}

	public void stopBite() {
		isBiting = false;

		topMotor.force = 0;
		bottomMotor.force = 0;
		topMotor.targetVelocity = 0;
		bottomMotor.targetVelocity = 0;
		
		jawTop.useMotor = false;
		jawTop.useSpring = true;
		
		jawBottom.useMotor = false;
		jawBottom.useSpring = true;
		
		//jawTop.rigidbody.freezeRotation = true;
		//jawBottom.rigidbody.freezeRotation = true;
	}
}