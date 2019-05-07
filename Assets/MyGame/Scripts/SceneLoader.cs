using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadSceneMain()
    {
        SceneManager.LoadScene("MainScene");

    }
    public void LoadSceneEnd()
    {
        SceneManager.LoadScene("EndScene");
    }
    public void LoadSceneIntro()
    {
        SceneManager.LoadScene("IntroScene");
    }


}
