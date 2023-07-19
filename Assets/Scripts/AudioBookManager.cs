using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBookManager : MonoBehaviour
{
    public GameObject Droplets;

    // Start is called before the first frame update
    void Start()
    {
        Droplets.gameObject.SetActive(false);
    }

    public void DoSomething()
    {
        Debug.Log("Doing Something");

        Droplets.gameObject.SetActive(true);
    
    }
 public void StopSomething()
    {
        Droplets.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update() { }
}
