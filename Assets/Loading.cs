using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public AssetReference scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    private void OnGUI()
    {

        if (GUI.Button(new Rect(100, 100, 100, 50), "ÈÈ¸üÐÂ"))
        {
            scene.LoadSceneAsync();
        }
    }
}
