using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pullGame : MonoBehaviour
{

    public Rigidbody ball;
    public GetQuestInputs inputs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        ball.AddForce(-(ball.transform.position - inputs.rightLocation.position) * inputs.rightValue);
    }
}
