using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Axis_Controller : MonoBehaviour
{
    public Transform leftarm;
    public Transform rightarm;
    public Transform leftleg;
    public Transform rightleg;
    public Transform head;
    public Slider slide_x, slide_y;
    public Text txt;
    public int BodyPartIndex=1;
   
    Vector3 headposition, LA_position, RA_position, LL_position, RL_position;

    private void Start()
    {
        
        headposition = new Vector3(-0.12f,2.33f,0f);
        LA_position = new Vector3(0.377f,1f,0);
        LL_position = new Vector3(0.125f,0.07f,0f);
        RA_position = new Vector3(-0.359f,1.128f,0);
        RL_position = new Vector3(-0.24f,0.09f,0);


    }

    public void Bodypart_Selector(int value)
    {
        if (value == 0)
        {
            BodyPartIndex = 0;
        }
        else
        {
            BodyPartIndex += value;
            if (BodyPartIndex > 5)
            {
                BodyPartIndex = 1;
            }
            else
            if (BodyPartIndex < 1)
            {
                BodyPartIndex = 5;
            }
        }
        UIText(BodyPartIndex);
        // slider position checking
       
            slide_x.value = 0;
            slide_y.value = 0;
       
    }

    public void UIText(int bodypart)
    {
        switch (bodypart)
        {
            case 0:
                txt.text = "No Body Part Selected";
                bodypart = 0;
                break;
            case 1:
                txt.text = "Right Arm";
                break;
            case 2:
                txt.text = "Left Arm";
                break;
            case 3:
                txt.text = "Left Leg";
                break;
            case 4:
                txt.text = "Right Leg";
                break;
            case 5:
                txt.text = "Head";
                break;
        }
    }
    public void SliderValue_X(float slidervalue)
    {
        
        switch (BodyPartIndex)
        {
            case 1:
                rightarm.position = new Vector3(slidervalue+RA_position.x, rightarm.position.y, rightarm.position.z);
                break;
            case 2:
                leftarm.position = new Vector3(slidervalue+LA_position.x, leftarm.position.y, leftarm.position.z);
                break;
            case 3:
                leftleg.position = new Vector3(slidervalue+LL_position.x, leftleg.position.y, leftleg.position.z);
                break;
            case 4:
                rightleg.position = new Vector3(slidervalue+RL_position.x, rightleg.position.y, rightleg.position.z);
                break;
            case 5:
                head.position = new Vector3(slidervalue+headposition.x, head.position.y, head.position.z);
                break;
        }
    }
    public void SliderValue_Y(float slidervalue)
    {
       

        switch (BodyPartIndex)
        {
            case 1:
                rightarm.position = new Vector3(rightarm.position.x, slidervalue+ RA_position.y, rightarm.position.z);
                break;
            case 2:
                leftarm.position = new Vector3(leftarm.position.x, slidervalue + LA_position.y, leftarm.position.z);
                break;
            case 3:
                leftleg.position = new Vector3(leftleg.position.x, slidervalue + LL_position.y, leftleg.position.z);
                break;
            case 4:
                rightleg.position = new Vector3(rightleg.position.x, slidervalue + RL_position.y, rightleg.position.z);
                break;
            case 5:
                head.position = new Vector3(head.position.x, slidervalue + headposition.y, head.position.z);
                break;
        }

    }
}
