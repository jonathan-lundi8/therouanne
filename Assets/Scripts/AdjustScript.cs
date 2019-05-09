using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustScript : MonoBehaviour
{
    void Awake()
    {
    }

    void OnGUI()
    {



        GUI.Label(new Rect(10, 10, 100, 30), "Health : " + GameControl.control.data.health);
        GUI.Label(new Rect(10, 50, 100, 30), "Experience : " + GameControl.control.data.experience);


        if (GUI.Button(new Rect(10, 100, 100, 30), "Health up"))
        {
            GameControl.control.data.health += 10;
        }
        if (GUI.Button(new Rect(10, 140, 100, 30), "Health down"))
        {
            GameControl.control.data.health -= 10;
        }
        if (GUI.Button(new Rect(10, 180, 100, 30), "Experience Up"))
        {
            GameControl.control.data.experience += 10;
        }
        if (GUI.Button(new Rect(10, 220, 100, 30), "Experience down"))
        {
            GameControl.control.data.experience -= 10;
        }
        if (GUI.Button(new Rect(10, 260, 100, 30), "Save"))
        {
            GameControl.control.SaveData();
        }
        if (GUI.Button(new Rect(10, 300, 100, 30), "Load"))
        {
            GameControl.control.LoadData();
        }
    }


}
