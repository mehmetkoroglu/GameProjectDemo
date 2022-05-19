using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPaint : MonoBehaviour
{

    public GameObject Brush;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);        
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.CompareTag("Wall"))
                {
                    var paint = Instantiate(Brush, hit.point + Vector3.up * 0.1f, Quaternion.identity, transform);
                    paint.transform.localScale = Vector3.one * 0.1f;
                }
            }
        }
    }
}