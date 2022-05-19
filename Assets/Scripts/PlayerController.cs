using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator _animator;
    Rigidbody boyRigidbody;
    public GameObject wall;

    bool canHeMove = true;
    float rotationAngle = 0f;
    public float moveSpeed = 10f;
    public float rotationSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        boyRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canHeMove)
        {
            float z = Input.GetAxis("Vertical") * moveSpeed; // for z direction
            float x = Input.GetAxis("Horizontal") * moveSpeed; // for x direction
            boyRigidbody.velocity = new Vector3(x, boyRigidbody.velocity.y, z);

            if (Input.GetAxis("Horizontal") > 0) rotationAngle = 30f; // right
            if (Input.GetAxis("Horizontal") < 0) rotationAngle = -30f; // left
            if (Input.GetAxis("Horizontal") == 0) rotationAngle = 0f; // forward

            _animator.SetBool("isRunning", Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, rotationAngle, 0), rotationSpeed);
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            canHeMove = false;
            wall.SetActive(true);
            _animator.SetBool("isRunning", false);
            CameraController.isHeFinished = true;
        }
    }
}
