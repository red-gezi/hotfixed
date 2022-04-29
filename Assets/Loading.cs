using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public partial class Loading : MonoBehaviour
{
    static AssetBundle ab;
    private void Start()
    {
        ab?.Unload(true);
        ab = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/AssetBundles/scene.gezi");
        SceneManager.LoadScene("hotfixed");
    }
    //private async void OnGUI()
    //{
    //    if (GUI.Button(new Rect(100, 100, 100, 50), "ÈÈ¸üÐÂ"))
    //    {
    //        ab = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/AssetBundles/scene.gezi");
    //        SceneManager.LoadScene("hotfixed");
    //    }
    //    if (GUI.Button(new Rect(100, 200, 100, 50), "Ð¶ÔØ"))
    //    {
    //        ab.Unload(true);
    //    }
    //}
}
