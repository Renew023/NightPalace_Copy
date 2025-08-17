using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    public void LoadIntroNextScene()
    {
        //LoadingUI.Instance.LoadScene("MainScene2");
        Debug.Log("로드씬 출력");
        SceneManager.LoadScene("MainScene");
    }

    public void LoadEndingNextScene()
    {
        SceneManager.LoadScene("StartScene");
    }
    
}
