using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToMission : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MessageScreen=null;
    public GameObject MissionScreen=null;
   
    public bool isMissionActive=false;
    public bool isIntroMessageActive=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackGroundChanger()
    {
   
     MessageScreen.SetActive(false);
     MissionScreen.SetActive(true);
    

} 
}
