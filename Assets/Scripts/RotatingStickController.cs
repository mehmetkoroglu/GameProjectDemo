using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingStickController : MonoBehaviour
{
    public float force = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * force, ForceMode.Impulse);
        }
        if (other.gameObject.CompareTag("Opponent"))
        {
            Vector3 respawnPoint = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, -19);
            other.gameObject.transform.position = Vector3.Lerp(other.gameObject.transform.position, respawnPoint, 0.9f); ;
        }

    }
}
