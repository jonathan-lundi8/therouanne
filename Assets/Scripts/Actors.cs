using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actors : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject actor;
    public GameObject[] actors;
    void Start()
    {
        // actors = new List<>
        for (int i = 0; i < 5; i++)
        {
            Instantiate(actor, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
