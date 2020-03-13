using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailBrush : MonoBehaviour
{


    public Transform puller;
    public GameObject painterPrefab;


    public int numberPainters;

    public GameObject[] painters;  
    public Rigidbody[] rbs;
    public LineRenderer[] lrs;
    public TrailRenderer[] trs;
    // Start is called before the first frame update
    void Start()
    {

        painters = new GameObject[numberPainters];
        rbs = new Rigidbody[numberPainters];
        lrs = new LineRenderer[numberPainters];
        trs = new TrailRenderer[numberPainters];

        for(int i = 0; i< numberPainters; i++){
            painters[i] = Instantiate(painterPrefab);
            rbs[i] = painters[i].GetComponent<Rigidbody>();
            lrs[i] = painters[i].GetComponent<LineRenderer>();
            trs[i] = painters[i].GetComponent<TrailRenderer>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        for( int i = 0; i<numberPainters; i++ ){

            rbs[i].drag = 8;
            rbs[i].mass = 1.1f;

            Vector3 target;
            if( i == 0 ){
             target = puller.position;
            }else{
             target = painters[i-1].transform.position;
            }

            rbs[i].AddForce((target - painters[i].transform.position) * 20);

            lrs[i].SetPosition(0 , target);
            lrs[i].SetPosition(1,painters[i].transform.position);

        }
        
    }
}
