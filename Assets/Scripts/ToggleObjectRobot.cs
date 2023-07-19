using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObjectRobot : MonoBehaviour
{
     public void Toggle()
    {
        gameObject.SetActive(!gameObject.activeSelf); //SetActive to toggle object on and off
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

