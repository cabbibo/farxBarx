using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class PlayInEditMode : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {

        
        GetComponent<AudioSource>().Play();

        
    }


    void OnDisable(){
         GetComponent<AudioSource>().Stop();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
