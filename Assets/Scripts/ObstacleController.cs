using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name.Equals("StaticObstacle"))
        {
            Vector3 fromPosition = new Vector3(gameObject.transform.position.x, 8, gameObject.transform.position.z);
            Vector3 toPosition = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z);
            gameObject.transform.position = Vector3.Lerp(fromPosition, toPosition, Mathf.PingPong(Time.time, 1));
        }
        if (gameObject.name.Equals("HorizontalObstacle"))
        {
            gameObject.transform.Rotate(0, 0.5f, 0);
            Vector3 fromPosition = new Vector3(-2, gameObject.transform.position.y, gameObject.transform.position.z);
            Vector3 toPosition = new Vector3(16, gameObject.transform.position.y, gameObject.transform.position.z);
            gameObject.transform.position = Vector3.Lerp(fromPosition, toPosition, Mathf.PingPong(Time.time, 1));
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Opponent"))
        {
            Vector3 respawnPoint = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, -19);
            other.gameObject.transform.position = Vector3.Lerp(other.gameObject.transform.position, respawnPoint, 0.9f); ;
        }
    }
}
