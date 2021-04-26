using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;
    public bool interacting;
    Vector3 velocity;
    [SerializeField]Animator animator;
    Vector3 movement;
    CharacterController controller;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        velocity.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        velocity = transform.TransformDirection(velocity);
        //transform.Translate(velocity.x, 0, velocity.y);
        controller.Move(velocity);
        movement = new Vector3(velocity.x, 0, velocity.y);
        if (movement.sqrMagnitude * 1000 > 0.1)
            animator.SetBool("Run", true);
        else if (movement.sqrMagnitude * 1000 < 0.1)
            animator.SetBool("Run", false);
        if (Input.GetKeyDown(KeyCode.E))
        {
            interacting = true;
            animator.SetBool("Aim", true);
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            interacting = false;
            animator.SetBool("Aim", false);
        }
    }
}
