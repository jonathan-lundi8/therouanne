using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciatePrefab : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject UI_TextScroll;
    public GameObject UI_Actors;

    void Awake()
    {
        Instantiate(UI_Actors, new Vector3(0, 0, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
