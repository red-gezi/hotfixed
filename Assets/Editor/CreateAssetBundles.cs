using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class CreateAssetBundles : MonoBehaviour
{
    [MenuItem("AssetBundles/Build AssetBundles")] //����
    static void BuildAssetBundle()
    {
        string dir = Application.streamingAssetsPath + "/AssetBundles"; //���·��
        string PCAssetBundles = @"G:\UnityProject\�ȸ��²���\PC\�ȸ��²���_Data\StreamingAssets\AssetBundles";
        Directory.CreateDirectory(dir);
        Directory.CreateDirectory(PCAssetBundles);
        BuildPipeline.BuildAssetBundles(dir, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
        BuildPipeline.BuildAssetBundles(PCAssetBundles, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
}
