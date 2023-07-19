using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource source;
    public AudioClip clip;

    void Start()
    {
        StartCoroutine (WaitBeforeStop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator WaitBeforeStop(){
        
    
       yield return new WaitForSeconds(5);

       StopSound();
       
    }

    private void StopSound(){
    
     source.Stop();
    
    }
}
