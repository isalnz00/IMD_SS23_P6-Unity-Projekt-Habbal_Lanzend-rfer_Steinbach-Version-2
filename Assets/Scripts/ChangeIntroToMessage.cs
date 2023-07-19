using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeIntroToMessage : MonoBehaviour
{
    // Start is called before the first frame update
    // public GameObject startscreen;
    // public GameObject introscreen;
    // public GameObject warningscreen;
    // public bool isStart=false;
    // public bool isIntro=false;
    // public bool isWarning=false;
   
    // public GameObject Introscreen;
    public GameObject Introscreen=null;
    // public GameObject warningscreen;
    public GameObject IntroscreenMessage=null;
    public bool isWelcome=false;
    public bool isIntro=false;
    public bool isIntroMessageActive=false;
    public AudioSource source;
     public AudioClip clip;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//     public void BackGroundChanger(){
//         if (isStart==false){
//           startscreen.SetActive(false);
//           introscreen.SetActive(true);
//           warningscreen.SetActive(false);  
//           isIntro=true;
//         } 
//         else if (isIntro==true){
//           startscreen.SetActive(false);
//           introscreen.SetActive(false);
//           warningscreen.SetActive(true); 
//           isIntro=false;
//           isWarning=true;
//         } 
//         // else if ( isWarning==true){
//         //   startscreen.SetActive(false);
//         //   introscreen.SetActive(false);
//         //   warningscreen.SetActive(true); 
         
          
//         // } 
         
//     }
// }

public void BackGroundChanger()
{
   
     Introscreen.SetActive(false);
     IntroscreenMessage.SetActive(true);
     PlaySound();

}   
 private void PlaySound(){
        //   Messagescreen.SetActive(true);
          isIntroMessageActive=true;

         if (isIntroMessageActive==true){
            source.PlayOneShot(clip);
        }
    }

}




// public void BackGroundChanger()
// {
//     if (isStart == false)
//     {
//         startscreen.SetActive(false);
//         introscreen.SetActive(true);
//         warningscreen.SetActive(false);  
//         isIntro = true;
//     } 
//     else if (isIntro == true && isWarning == false)
//     {
//         startscreen.SetActive(false);
//         introscreen.SetActive(false);
//         warningscreen.SetActive(true); 
//         isIntro = false;
//         isWarning = true;
//     } 
//     else if (isIntro == true && isWarning == true)
//     {
//         // Hier können Sie den Code einfügen, um den Warnbildschirm erneut zu behandeln,
//         // wenn der Button zum dritten Mal geklickt wird.
//     }
// }
// }
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ChangeBackground : MonoBehaviour
// {
//     public GameObject[] backgrounds;
//     private int backgroundNum = 0;
//     // Start is called before the first frame update
//     void Start()
//     {

//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }

//     public void BackGroundChangerLeft()
//     {
//         backgrounds[backgroundNum].SetActive(false);
//         backgroundNum--;
//         if (backgroundNum < 0)
//         {
//             backgroundNum = backgrounds.Length-1;
//         }
//         backgrounds[backgroundNum].SetActive(true);

//     }

//     public void BackGroundChangerRight()
//     {
//         backgrounds[backgroundNum].SetActive(false);
//         backgroundNum++;
//         if (backgroundNum == backgrounds.Length)
//         {
//             backgroundNum = 0;
//         }
//         backgrounds[backgroundNum].SetActive(true);
//     }
// }