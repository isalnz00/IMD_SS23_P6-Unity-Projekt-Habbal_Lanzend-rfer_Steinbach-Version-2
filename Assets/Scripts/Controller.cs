using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Welcomescreen=null;
    public GameObject Introscreen=null;
    public GameObject Messagescreen=null;
    // public GameObject Warnings=null;
<<<<<<< HEAD
    // public GameObject Missionscreen=null;
=======
    public GameObject Missionscreen=null;
>>>>>>> 2144a90dba2f0c98f9cc48fe33dd29a145fc6c01
    
    public AudioSource source;
    public bool isMessageActive=false;
    public AudioClip clip;
    // public GameObject Message=null;

    void Start()
    {
        Welcomescreen.SetActive(true);
        Introscreen.SetActive(false);
        Messagescreen.SetActive(false);
        // Warnings.SetActive(false);
        // ShowScreens();

        StartCoroutine (WaitBeforeShow());
        // StartCoroutine(WaitBeforeSetWarnings());
        // StartCoroutine(WaitBeforeReSetWarnings()); 
    }

    // Update is called once per frame
       

    //show the IntroScreen with background story when 5 seconds have passed
    private IEnumerator WaitBeforeShow(){
        
        Welcomescreen.SetActive(true);

        yield return new WaitForSeconds(6);

        // PlaySound();
        Introscreen.SetActive(true);
    }
    
    //set Warnings-Object true when 20s have passed and set Missionscreen to false
    // private IEnumerator WaitBeforeSetWarnings(){
        
    //     while(true)
    //     {
    //     Debug.Log("Wait before Warnings are set true");

    //     yield return new WaitForSeconds(40);
    //      Debug.Log("20 Seconds are over");
    //     // PlaySound();

    //     //Warnings will show up
    //     Warnings.SetActive(true);
<<<<<<< HEAD
    //     // Missionscreen.SetActive(false);
=======
    //     Missionscreen.SetActive(false);
>>>>>>> 2144a90dba2f0c98f9cc48fe33dd29a145fc6c01
    //     }

    // }
    //   private IEnumerator WaitBeforeReSetWarnings(){
        
    //     while(true)
    //     {
    //      yield return new WaitForSeconds(60);
    //     Debug.Log("40 Seconds are over");
        
    //     //Set Warnings false
    //     Warnings.SetActive(false);
<<<<<<< HEAD
    //     // Missionscreen.SetActive(true);   
=======
    //     Missionscreen.SetActive(true);   
>>>>>>> 2144a90dba2f0c98f9cc48fe33dd29a145fc6c01
    //     }
        
        
    // }
      
}
