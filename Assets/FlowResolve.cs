using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IMMATERIA;

public class FlowResolve : Cycle
{

    public Form form;
    public Life life;
    public Life resolve;

    public string nameInBuffer;

  public Binder[] binders;
    // Start is called before the first frame update
  // Use this for initialization
  public override void _Create(){
        
        SafeInsert(form);
        SafeInsert(life);
        SafeInsert(resolve);

        binders = GetComponents<Binder>();
     
        for( int i = 0 ; i < binders.Length; i++ ){
            SafeInsert( binders[i] );
        }

        
        DoCreate();

    }

   
  public override void _Bind(){

      print(nameInBuffer);
    life.BindPrimaryForm(nameInBuffer, form); 
    resolve.BindPrimaryForm(nameInBuffer, form); 
    
    Bind();

  }
}
