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
    static FileInfo ab=> new FileInfo(@"G:\UnityProject\热更新测试\PC\热更新测试_Data\StreamingAssets\AssetBundles\scene.gezi");
    void Start()
    {
    //    ab = new FileInfo(@"G:\UnityProject\热更新测试\PC\热更新测试_Data\StreamingAssets\AssetBundles\scene.gezi");
    //    ab = new FileInfo(@"G:\UnityProject\热更新测试\Assets\StreamingAssets\AssetBundles\scene.gezi");
        lastUpdateTime = ab.LastWriteTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (lastUpdateTime != ab.LastWriteTime)
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
            lastUpdateTime = ab.LastWriteTime;
        }
    }
    private async Task OnGUI()
    {
        if (GUI.Button(new Rect(100, 100, 100, 50), "返回"))
        {
            //SceneManager.LoadScene(0,LoadSceneMode.Single);
            //await Task.Delay(1000);
            //Loading.Unload();
        }
    }
}
