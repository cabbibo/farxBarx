using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCollide : MonoBehaviour
{

  public pullGame game;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter( Collider c ){
      if( c.tag == "Hand"){
        //game.Lose();
      }else if( c.tag == "Target"){
        game.Score();
      }else if( c.tag == "Shark"){
        game.Lose();
      }
    }
}
