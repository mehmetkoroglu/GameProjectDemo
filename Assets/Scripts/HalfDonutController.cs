using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonutController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fromPosition = new Vector3(0.1f, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z);
        Vector3 toPosition = new Vector3(-0.1f, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z);
        gameObject.transform.localPosition = Vector3.Lerp(fromPosition, toPosition, Mathf.PingPong(Time.time, 1));
    }
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Opponent"))
        {
            Vector3 respawnPoint = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, -19);
            other.gameObject.transform.position = Vector3.Lerp(other.gameObject.transform.position, respawnPoint, 0.9f); ;
        }
    }
}
