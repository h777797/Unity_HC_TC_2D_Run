﻿using UnityEngine;
using UnityEngine.SceneManagement; // 引用 場景管理 API

/// <summary>
/// 場景控制:切換場景、離開遊戲
/// <summary>

public class SceneControl : MonoBehaviour
{
  public void Quit()
    {
        Application.Quit();    //應用程式、離開()
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("遊戲場景"); //場景管理、載入場景("場景名稱")
    }

    public void DelayLoadScene()
    {
        //延遲呼叫("方法名稱"，延遲時間)
        Invoke("LoadScene", 0.8f);
    }

    public void DelayLoadQuit()
    {
        Invoke("LoadQuit", 0.8f);
    }
}
