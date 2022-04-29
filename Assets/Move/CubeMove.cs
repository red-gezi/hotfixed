using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<Renderer>().material.color =Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=new Vector3( Mathf.Sin(Time.time*2), Mathf.Cos(Time.time*2)*5, 0);
        transform.localScale=new Vector3( Mathf.Sin(Time.time*2), Mathf.Cos(Time.time*2)*5, 0);
        transform.eulerAngles=new Vector3(Time.time, Time.time, 0);
    }
}
