using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UI_Actor;
    void Start()
    {
        GameObject actor1 = Instantiate(UI_Actor, new Vector3(100, 100, 0), Quaternion.identity);
        // Instantiate(UI_Actor, new Vector3(200, 0, 0), Quaternion.identity);
        // Instantiate(UI_Actor, new Vector3(300, 0, 0), Quaternion.identity);
        actor1.transform.parent = gameObject.transform;
        actor1.transform.GetChild(0).gameObject.GetComponent<Text>().text = "sqkmflskdfmksdmfksmdfkmdsfkmsdk";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
