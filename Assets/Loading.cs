using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public AssetReference scene;
    static public Loading instance;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }
    // Update is called once per frame
    private void OnGUI()
    {

        if (GUI.Button(new Rect(100, 100, 100, 50), "热更新"))
        {
            //Addressables.CheckForCatalogUpdates();
            //貌似第一次会从网络拿到缓存，第二次以后都是直接读缓存，不知道怎么更新版本
            //我想第一次判断版本对不对，不对的话下载到本地，之后都从本地下载，每次加载前都能校验版本
            scene.LoadSceneAsync();
        }
        if (GUI.Button(new Rect(100, 200, 100, 50), "卸载"))
        {
            //Addressables.CheckForCatalogUpdates();
            instance.scene.UnLoadScene();
        }
    }
    public static void Unload()
    {
        instance.scene.UnLoadScene();
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
