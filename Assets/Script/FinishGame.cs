using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{

   public  bool LA, RA, LL, RL;
    
    public void finishcondition(int index,bool col)
    {
       
        switch (index)
        {
            case 1:
                LA = col;
                Debug.Log("collision happened");
                break;
            case 2:
                Debug.Log("collision happened");
                RA = col;
                break;
            case 3:
                Debug.Log("collision happened");
                LL = col;
                break;
            case 4:
                Debug.Log("collision happened");
                RL = col;
                break;
        }

        if(LA&&RA&&LL&&RL)
        {
            SceneManager.LoadScene("End",LoadSceneMode.Single);
        }
        
    }
    
}
