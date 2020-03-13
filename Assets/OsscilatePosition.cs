using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class OsscilatePosition : MonoBehaviour
{

    public float speed;
    public float size;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      #if UNITY_EDITOR

        float x = Mathf.Sin( Time.time * speed + Mathf.Sin( Time.time * speed * 20f) * size * .5f ) * size;
        float y = Mathf.Sin( .8f + .95f* Time.time * speed + Mathf.Sin( Time.time * speed * 21f) * size * .7f ) * size;
        float z = Mathf.Sin( .7f + .8f * Time.time * speed + Mathf.Sin( Time.time * speed * 23f) * size * .6f ) * size;
        transform.position = new Vector3( x , y , z);
        
      #else

        transform.position = Vector3.zero;
      #endif

    }
}
