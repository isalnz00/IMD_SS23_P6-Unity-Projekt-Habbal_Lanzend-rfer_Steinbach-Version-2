using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script handles toggling specific "GameObjects" (sounds, images, etc.) on or off Onclick onto a robot part.
public class ClickActionManagerRender : MonoBehaviour
{
    public GameObject actionToTake;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Script start"); //this works
        //actionToTake.gameObject.SetActive(false);
        //^If you click for a second time, this should turn off the action before running the code to start it again.
        //Prevents things like layering of soundfiles. Update: for this to actually work it needs to NOT be in the start function, since this part of the script runs only at the START, once.
        //Clicking again doesn't do anything yet.
    }

    // Update is called once per frame
    void Update() { }

    public void ToggleGameObject()
    {
        Debug.Log("TOGGLING");
        //if condition should check here whether the effect is already active or not. if not, it should be stopped first before executing it again.
        if (!actionToTake.activeInHierarchy)
        {
            Debug.Log("Toggle ON cause off");
            gameObject.GetComponent<Renderer>().enabled = true;
        }
        else if (actionToTake.activeInHierarchy)
        {
            Debug.Log("Toggle OFF cause on");
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

    //   void OnDisable()
    // {
    //     //do the opposite of what "OnMouseDown" did at any given time, thus resetting everything to it's default state
    //     if (!actionToTake.activeInHierarchy)
    //     {
    //         Debug.Log("Toggle ON cause off");
    //         actionToTake.gameObject.SetActive(true);
    //     }
    //      if (actionToTake.activeInHierarchy)
    //     {
    //         Debug.Log("Toggle OFF cause on");
    //         actionToTake.gameObject.SetActive(false);
    //     }
    // }
}
