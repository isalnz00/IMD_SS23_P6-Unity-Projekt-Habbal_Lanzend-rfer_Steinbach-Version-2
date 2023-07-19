using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasToggle : MonoBehaviour
{   
     public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        // Schaltet den Canvas beim Starten des Spiels aus
        // canvas.enabled = false;
    }

    
    public void ToggleCanvas()
    {
        // Schaltet den Canvas ein oder aus, je nach aktuellem Zustand
        canvas.enabled = !canvas.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
