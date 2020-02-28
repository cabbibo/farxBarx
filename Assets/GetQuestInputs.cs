using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetQuestInputs : MonoBehaviour
{


    public float leftValue;
    public float rightValue;
    public TextMesh leftVal;
    public TextMesh rightVal;

    public Transform leftLocation;
    public Transform rightLocation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      OVRInput.Update();
        
    }

    void FixedUpdate(){
      OVRInput.FixedUpdate();

      // returns a float of the secondary (typically the Right) index finger trigger’s current state.
// (range of 0.0f to 1.0f)
      rightValue = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);
      leftValue = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger);

      leftVal.text = " left : " + leftValue;
      rightVal.text = " right : " + rightValue;

    }
}
