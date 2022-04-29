using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class CreateAssetBundles : MonoBehaviour
{
    [MenuItem("AssetBundles/Build AssetBundles")] //特性
    static void BuildAssetBundle()
    {
        string dir = Application.streamingAssetsPath + "/AssetBundles"; //相对路径
        string PCAssetBundles = @"D:\vs2022-Project\hotfixed\PC\hotfixed_Data\StreamingAssets\AssetBundles";
        Directory.CreateDirectory(dir);
        Directory.CreateDirectory(PCAssetBundles);
        BuildPipeline.BuildAssetBundles(dir, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
        BuildPipeline.BuildAssetBundles(PCAssetBundles, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
}
