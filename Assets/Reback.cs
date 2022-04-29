using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reback : MonoBehaviour
{
    // Start is called before the first frame update
    static DateTime lastUpdateTime;
    static FileInfo ab => new FileInfo(Application.streamingAssetsPath + "/AssetBundles/scene.gezi");
    public GameObject cube;
     async void Start()
    {
        cube.AddComponent(DllManager.GetScript());
        lastUpdateTime = ab.LastWriteTime;
        await Task.Delay(3140);
        Debug.Log("重载场景");
        SceneManager.LoadScene(0);

    }
    void Update()
    {

        if (lastUpdateTime != ab.LastWriteTime)
        {
            Debug.Log("重载场景");
            lastUpdateTime = ab.LastWriteTime;
            SceneManager.LoadScene(0);
        }
    }
    //private async Task OnGUI()
    //{
    //    if (GUI.Button(new Rect(100, 100, 100, 50), "返回"))
    //    {
    //        //SceneManager.LoadScene(0,LoadSceneMode.Single);
    //        //await Task.Delay(1000);
    //        //Loading.Unload();
    //    }
    //}
}
