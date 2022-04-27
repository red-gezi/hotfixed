using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
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
    private async Task OnGUI()
    {
        if (GUI.Button(new Rect(100, 100, 100, 50), "·µ»Ø"))
        {
            SceneManager.LoadScene(0,LoadSceneMode.Single);
            await Task.Delay(1000);
            Loading.Unload();
        }
    }
}
