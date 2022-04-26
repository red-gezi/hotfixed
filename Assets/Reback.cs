using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reback : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        if(GUI.Button(new Rect(100,100,100,50),"·µ»Ø"))
        {
            SceneManager.LoadSceneAsync(0);
        }
    }
}
