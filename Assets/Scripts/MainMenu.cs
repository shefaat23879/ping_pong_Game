using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnePlayer(){
        SceneManager.LoadScene("PlayerVSAI");
    }
     public void TwoPlayer(){
        SceneManager.LoadScene("PlayerVSPlayer");
    }
}
