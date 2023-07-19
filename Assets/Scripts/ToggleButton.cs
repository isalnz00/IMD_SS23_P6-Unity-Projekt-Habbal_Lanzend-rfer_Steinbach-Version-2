using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
    // Start is called before the first frame update
    public ToggleObjectRobot toggleObject;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }

     private void OnButtonClick()
    {
        Debug.Log("Bauplan wurde angeklickt");
        toggleObject.Toggle();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
