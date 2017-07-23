using UnityEngine;
using System.Collections;

public class AnyaMove : MonoBehaviour {

	public Animator anim;
	private float walkSpeed;
	private float fallSpeed;
	private float verticalMovement;
	private float horizontalMovement;
	private bool onGround;
	private bool isIdle;
	private bool isWalkingFwd;
	private bool isWalkingBck;
	private WalkDirection walkDirection;
	// Use this for initialization
	void Start () {
		onGround = true;
		isIdle = true;
		walkDirection = WalkDirection.Right;
		walkSpeed = 0.05f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow) && onGround) {
			isIdle = false;
			isWalkingFwd = true;
			horizontalMovement = walkSpeed;			
		}
		if (Input.GetKeyUp(KeyCode.RightArrow) && onGround) {
			isWalkingFwd = false;
			isIdle = true;
		}

	}

	private enum WalkDirection
	{
		Right = 0,
		Left = 1
	}
}
