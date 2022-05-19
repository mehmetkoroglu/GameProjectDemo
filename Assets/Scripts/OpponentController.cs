using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentController : MonoBehaviour
{
    Rigidbody _rigidbody;
    public float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().SetBool("isSheRunning", true);
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, _rigidbody.velocity.y, moveSpeed);

        if (gameObject.transform.position.y < 4)
        {
            Vector3 respawnPoint = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -19);
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, respawnPoint, 0.9f);
        }
    }
}
