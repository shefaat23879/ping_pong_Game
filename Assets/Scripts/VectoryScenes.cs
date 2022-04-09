using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VectoryScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadScenes",3);
    }

    // Update is called once per frame
    public void LoadScenes(){
        SceneManager.LoadScene("MainMenu");
    }
}
