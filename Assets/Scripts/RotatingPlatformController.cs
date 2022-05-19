using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatformController : MonoBehaviour
{
    public float force = 5f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name.Equals("RotatingPlatformToRight")) transform.Rotate(0, 0, -0.25f);
        if (gameObject.name.Equals("RotatingPlatformToLeft")) transform.Rotate(0, 0, 0.25f);
        if (gameObject.name.Equals("Rotator")) transform.Rotate(0, 0.5f, 0);
    }

    private void OnCollisionStay(Collision other)
    {
        if (gameObject.name.Equals("RotatingPlatformToRight"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * force, ForceMode.Impulse);
        }
        if (gameObject.name.Equals("RotatingPlatformToLeft"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * force, ForceMode.Impulse);
        }
    }
}
