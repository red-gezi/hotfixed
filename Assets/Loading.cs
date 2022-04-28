using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    static public Loading instance;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        //Addressables.InitializeAsync();
        //Directory.CreateDirectory(Application.streamingAssetsPath);
        //Directory.CreateDirectory(Application.dataPath);
        //File.WriteAllText(Application.dataPath + "/data.txt", Application.dataPath);
        //File.WriteAllText(Application.streamingAssetsPath + "/data.txt", Application.streamingAssetsPath);
        //var data=  GetWebRequest(@"http://127.0.0.1:5565/catalog_2022.04.28.00.43.55.json");
    }
    private static string GetWebRequest(string getUrl)
    {
        string responseContent = "";
        
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(getUrl);
        request.ContentType = "application/json";
        request.Method = "GET";

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //在这里对接收到的页面内容进行处理
        using (Stream resStream = response.GetResponseStream())
        {
            using (StreamReader reader = new StreamReader(resStream, Encoding.UTF8))
            {
                responseContent = reader.ReadToEnd().ToString();
            }
        }
        return responseContent;
    }
    // Update is called once per frame
    static AssetBundle ab;
    private void Start()
    {
        ab?.Unload(true);
        ab = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/AssetBundles/scene.gezi");
        SceneManager.LoadScene("hotfixed");
    }
    private async void OnGUI()
    {

        if (GUI.Button(new Rect(100, 100, 100, 50), "热更新"))
        {
             ab = AssetBundle.LoadFromFile(Application.streamingAssetsPath+ "/AssetBundles/scene.gezi");
            SceneManager.LoadScene("hotfixed");
            //ab.LoadAssetAsync<Scene>("hotfixed").completed += (scene =>
            //{
               
            //});
            //包中的场景名字
            
            //Addressables.LoadAsset
            //Addressables.LoadSceneAsync("scene", LoadSceneMode.Single).Completed += (obj =>
            //{
            //    sceneInstance= obj.Result;
            //});
        }
        if (GUI.Button(new Rect(100, 200, 100, 50), "卸载"))
        {
            ab.Unload(true);
        }
    }
    //Addressables.CheckForCatalogUpdates();
    //var handle = Addressables.CheckForCatalogUpdates(false);
    //await handle.Task;
    //handle.Completed += Handle_Completed;
    //Addressables.UpdateCatalogs();
    //Addressables.DownloadDependenciesAsync(scene);

    //貌似第一次会从网络拿到缓存，第二次以后都是直接读缓存，不知道怎么更新版本
    //我想第一次判断版本对不对，不对的话下载到本地，之后都从本地下载，每次加载前都能校验版本

    public static void Unload()
    {
        //instance.scene.UnLoadScene();
    }
    //IEnumerator Start()
    //{

    //    //只要打包的时候不要将Disable  Catalog Update on Startup勾选上就行，这样初始化的时候会自动更新Catalog到最新
    //    yield return Addressables.InitializeAsync();

    //    IEnumerable<IResourceLocator> locators = Addressables.ResourceLocators;
    //    List<object> keys = new List<object>();
    //    //暴力遍历所有的key
    //    foreach (var locator in locators)
    //    {
    //        foreach (var key in locator.Keys)
    //        {
    //            keys.Add(key);
    //        }
    //    }

    //    var handle = Addressables.GetDownloadSizeAsync(keys);
    //    yield return handle;
    //    long downloadSize = handle.Result;

    //    if (downloadSize > 0)
    //    {
    //        yield return Addressables.DownloadDependenciesAsync(keys, Addressables.MergeMode.Union, true);
    //    }
    //}
}
