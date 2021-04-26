using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllor : MonoBehaviour
{
	// Start is called before the first frame update
	[SerializeField] private Transform target;
	private float runSpeed = 6.0f;
	private float walkSpeed = 2.0f;
    private Animator animator;
	private CharacterController charController;

	private ControllerColliderHit _contact;

	public float moveSpeed = 6.0f;
	public float rotSpeed = 15.0f;
	public bool interacting = false;


	void Start()
    {
        animator = this.GetComponent<Animator>();
		charController = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 movement = Vector3.zero;

		if (Input.GetKeyDown("left shift"))
			moveSpeed = runSpeed;
		else if (Input.GetKeyUp("left shift"))
			moveSpeed = walkSpeed;
		// x z movement transformed relative to target
		float horInput = Input.GetAxis("Horizontal");
		float vertInput = Input.GetAxis("Vertical");
		if (horInput != 0 || vertInput != 0)
		{
			movement.x = horInput * moveSpeed;
			movement.z = vertInput * moveSpeed;
			movement = Vector3.ClampMagnitude(movement, moveSpeed);

			Quaternion direction = Quaternion.LookRotation(movement);
			transform.rotation = Quaternion.Lerp(transform.rotation,
												 direction, rotSpeed * Time.deltaTime);
		}
		animator.SetFloat("Speed", movement.sqrMagnitude);

		movement *= Time.deltaTime;
		charController.Move(movement);

		if (Input.GetKeyDown(KeyCode.E))
        {
			interacting = true;
        }
		else if (Input.GetKeyUp(KeyCode.E))
			interacting = false;
	}
}
