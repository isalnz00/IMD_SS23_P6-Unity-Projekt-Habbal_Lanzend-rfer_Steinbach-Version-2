using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script handles clicking of the robot parts and running the code for the corresponding action. 
//E.g. calling the soundfile on click onto the robot part. Those files are added as variables in Unity.

public class RobotPart : MonoBehaviour
{
    // public ClickActionManager action;
    public SoundManager1 soundManager1;
    // void Start()
    // {
    //     soundManager1 = FindObjectOfType<SoundManager1>();
    // }

    public void OnMouseDown()
    {
        Debug.Log("Clicked Object");

        // action.ToggleGameObject();


        if (gameObject.tag == "Arm")
        {
            soundManager1.playAudioArme();
            Debug.Log("Arme");

        }
        if (gameObject.tag == "Rad")
        {
            soundManager1.playAudioRaeder();
            Debug.Log("Rad");
        }

        if (gameObject.tag == "Kopf1")
        {
            soundManager1.playAudioKopf1();
            Debug.Log("Kopf1");
        }

        if (gameObject.tag == "Kopf2")
        {
            soundManager1.playAudioKopf2();
            Debug.Log("Kopf2");
        }

          if (gameObject.tag == "Ersatz")
        {
            soundManager1.playAudioErsatz();
            Debug.Log("Ersatz");
        }
    }

}
