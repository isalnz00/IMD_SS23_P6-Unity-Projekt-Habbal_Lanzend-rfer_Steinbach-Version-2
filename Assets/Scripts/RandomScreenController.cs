// using UnityEngine;
// using System.Collections;

// public class RandomScreenController : MonoBehaviour
// {
//     public GameObject[] screens;
//     public float minDisplayTime = 2f;
//     public float maxDisplayTime = 10f;
//     public Animator Warning;
    



//     private void Start()
//     {   
//         //Debug.Log("Timer läuft!");
//         // StartCoroutine(DelayedFunction());
//         StartCoroutine(DisplayRandomScreen());
//             }

//     //  private IEnumerator DelayedFunction()
//     // {
//     //     yield return new WaitForSeconds(20f); // Time Delay von 30 Sekunden

//     //     // Hier kannst du den restlichen Code oder die Funktionen aufrufen
//     //     Debug.Log("Time Delay abgelaufen!");
//     //     DisplayRandomScreen();
//     //     // Function2();
//     // }

//     IEnumerator DisplayRandomScreen()
//     {
//         while (true)
//         {
//             // Zufälligen Index für den Bildschirm auswählen
//             int randomIndex = Random.Range(0, screens.Length);


//             // Aktiviere den ausgewählten Bildschirm
//             screens[randomIndex].SetActive(true);
//             Warning.SetTrigger("Warning");

//             // Warte für eine zufällige Zeit
//             yield return new WaitForSeconds(Random.Range(minDisplayTime, maxDisplayTime));

//             // Deaktiviere den Bildschirm
//             screens[randomIndex].SetActive(false);
//         }
//     }
// }

using UnityEngine;
using System.Collections;

public class RandomScreenController : MonoBehaviour
{
    public GameObject[] screens;
    // public float minDisplayTime = 2f;
    // public float maxDisplayTime = 10f;
    public GameObject ProblemSolvedScreen=null;
    

    // private bool startWarnings=false; //if true Warnings start over again
    public Animator Warning;

    //THIS IS SO THAT ALL THE SUB_GameObjects OF "Warnings" CAN BE DEACTIVATED, SO AS TO RESET WARNINGS BACK TO IT'S INITIAL STATE SO IT CAN START OVER PROPERLY
    public GameObject Image_1;
    public GameObject Image_2;
    public GameObject Image_3;
    public GameObject WarningSign;

    void OnEnable()
    {
        //Mission setactive
        // Debug.Log("Mission Screen");
        StartCoroutine(DisplayRandomScreen());
    }


    //public void StartWarnings()
    // void Start()
    // {
    //     //Mission setactive
    //     Debug.Log("Mission Screen");
    //     StartCoroutine(DisplayRandomScreen());
    // }

    IEnumerator DisplayRandomScreen()
    {
        // while (true){
           // Warte für eine zufällige Zeit (Start Mission bis erste Warnung Störung)
            // yield return new WaitForSeconds(20); //später 30

            // Zufälligen Index für den Bildschirm auswählen
            int randomIndex = Random.Range(0, screens.Length);

            // Aktiviere den ausgewählten Bildschirm
            screens[randomIndex].SetActive(true);
            Debug.Log("Warning Screen");


            // Spiele Warndreieck-Simulation einmal ab
            Warning.SetTrigger("Warning");


            yield return new WaitForSeconds(10); //individuell je nach Error

            ProblemSolvedScreen.SetActive(true);
            Debug.Log("Behoben Screen");

    }

    void OnDisable()
    {
        Image_1.SetActive(false);
        Image_2.SetActive(false);
        Image_3.SetActive(false);
        WarningSign.SetActive(false);
        ProblemSolvedScreen.SetActive(false);
    }
}