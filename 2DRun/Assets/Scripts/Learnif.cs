﻿using UnityEngine;

public class Learnif : MonoBehaviour
{
    public bool test;

    private void Start()
    {
        // 語法:
        // 如果(布林值) { 程式內容 }
        // 作用: 當布林值為 ture 才會執行{} 程式內容
        if(test)
        {
            print("我是判斷式");
        }
    }

    public bool Opendoor;

    public void Update()
    {
        if (Opendoor)
        {
            print("開門");
        }

        else 
        {
            print("關門");
        }
    }

}
