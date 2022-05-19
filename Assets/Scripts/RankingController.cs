using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingController : MonoBehaviour
{

    GameObject[] characters, ranks;
    // Start is called before the first frame update
    void Start()
    {
        ArrayList distance = new ArrayList();
        characters = GameObject.FindGameObjectsWithTag("Opponent");
        ranks = GameObject.FindGameObjectsWithTag("Ranking");

        for (int i = 0; i < characters.Length; i++)
        {
            ranks[i].GetComponent<Text>().text = characters[i].gameObject.name;
        }

        foreach (GameObject item in characters)
        {
            distance.Add(190 - item.transform.position.z);
        }
        distance.Sort();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
