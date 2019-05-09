using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SequenceController : MonoBehaviour
{
    public GameObject sequenceManager;
  
    void Awake()
    {
        if(SequenceManager.instance == null){
            Instantiate(sequenceManager);
        }
    }
}



