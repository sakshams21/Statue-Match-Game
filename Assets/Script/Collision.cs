using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public int index;
    public GameObject abc;
    
    private void OnTriggerEnter(Collider other)
    {

        abc.GetComponent<FinishGame>().finishcondition(index, true); ;
    }

    private void OnTriggerExit(Collider other)
    {
        abc.GetComponent<FinishGame>().finishcondition(index, false); ;

    }
}
