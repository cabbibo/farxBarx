using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class pullGame : MonoBehaviour
{

    public LineRenderer sharkLR;
    public LineRenderer ballLR;
    public Rigidbody ball;
    public Rigidbody shark;
    public GetQuestInputs inputs;
    public Transform puller;

    public PressButton massSlider;
    public PressButton forceSlider;
    public PressButton dragSlider;

    
    public PressButton massSlider_shark;
    public PressButton forceSlider_shark;
    public PressButton dragSlider_shark;

    public float massMin;
    public float massMax;

    public float forceMin;
    public float forceMax;

    public float dragMin;
    public float dragMax;


    public float massMin_shark;
    public float massMax_shark;

    public float forceMin_shark;
    public float forceMax_shark;

    public float dragMin_shark;
    public float dragMax_shark;

    public int score;
    public TextMesh scoreText;

    public Transform target;
    // Start is called before the first frame update
    void Start()
    {

      UpdateScore();
        
    }

    // Update is called once per frame
    void Update()
    {

      ball.mass = massMin + ( massMax-massMin) * massSlider.SliderValue;
      ball.drag = dragMin + ( dragMax-dragMin) * dragSlider.SliderValue;

 
      float force = forceMin + ( forceMax-forceMin) * forceSlider.SliderValue;

      force = 2f;
      ball.mass = .3f;
      ball.drag = 2;
      
        
      ball.AddForce(-(ball.transform.position - puller.position) * force * inputs.rightValue);

      ballLR.SetPosition( 0 , ball.transform.position );
      ballLR.SetPosition( 1 , puller.position );



      shark.mass = massMin_shark + ( massMax_shark -massMin_shark ) * massSlider_shark.SliderValue;
      shark.drag = dragMin_shark  + ( dragMax_shark -dragMin_shark ) * dragSlider_shark.SliderValue;

      force = forceMin_shark  + ( forceMax_shark -forceMin_shark ) * forceSlider_shark.SliderValue;
        

        
      force = 2f;
      shark.mass = .3f;
      shark.drag = 2;
      shark.AddForce(-(shark.transform.position - ball.transform.position) * force);

      sharkLR.SetPosition( 0 , shark.transform.position );
      sharkLR.SetPosition( 1 , ball.transform.position );


    }


    public void Score(){
      score ++;
      UpdateScore();
    }

    public void Lose(){

      score = 0;
      UpdateScore();

    }

    public void UpdateScore(){
      scoreText.text =  "score : " + score;
      target.position = Random.insideUnitSphere * .3f + Vector3.up * 1 + Vector3.forward * .3f;
    }


}
