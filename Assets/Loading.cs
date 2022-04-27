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

        if (GUI.Button(new Rect(100, 100, 100, 50), "�ȸ���"))
        {
            //Addressables.CheckForCatalogUpdates();
            //ò�Ƶ�һ�λ�������õ����棬�ڶ����Ժ���ֱ�Ӷ����棬��֪����ô���°汾
            //�����һ���жϰ汾�Բ��ԣ����ԵĻ����ص����أ�֮�󶼴ӱ������أ�ÿ�μ���ǰ����У��汾
            scene.LoadSceneAsync();
        }
        if (GUI.Button(new Rect(100, 200, 100, 50), "ж��"))
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

    //    //ֻҪ�����ʱ��Ҫ��Disable  Catalog Update on Startup��ѡ�Ͼ��У�������ʼ����ʱ����Զ�����Catalog������
    //    yield return Addressables.InitializeAsync();

    //    IEnumerable<IResourceLocator> locators = Addressables.ResourceLocators;
    //    List<object> keys = new List<object>();
    //    //�����������е�key
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
