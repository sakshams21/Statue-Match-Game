using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_controller : MonoBehaviour
{
    public Animator ani;
    int ani_sequence=1;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        ani.SetInteger("Index",1);
    }

    public void index(int value)
    {
      
        ani_sequence += value;
        if (value == 10)
        {
            ani.Play("Default");
            ani_sequence = 0 ;
            ani.SetInteger("Index",0);
        }
        else {
            if (ani_sequence > 5)
            {
                ani_sequence = 1;
            }
            else
                if (ani_sequence < 1)
            {
                ani_sequence = 5;
            }
            switch (ani_sequence)
            {
                case 1:
                    ani.SetInteger("Index", 1);
                    break;
                case 2:
                    ani.SetInteger("Index", 2);
                    break;
                case 3:
                    ani.SetInteger("Index", 3);
                    break;
                case 4:
                    ani.SetInteger("Index", 4);
                    break;
                case 5:
                    ani.SetInteger("Index", 5);
                    break;
              
            }
        }
        
    }
}
