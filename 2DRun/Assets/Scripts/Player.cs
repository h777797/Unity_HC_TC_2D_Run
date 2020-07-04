using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位區域
    /* 說明區域
    // 命名規則
    // 1. 用有意義的名稱
    // 2. 不要使用數字開頭
    // 3. 不要使用特殊符號包含：@#/* 空格
    // 4. 可以使用中文 (不建議)

    // 欄位語法
    // 修飾詞 類型 欄位名稱 = 值;
    // 沒有 = 值 會以預設值為主
    // 整數、浮點數 預設值 0
    // 字串 預設值 ""
    // 布林值 預設值 false

    // 私人 private - 僅限於此類別使用 | 不會顯示 - 預設值
    // 公開 public  - 所有類別皆可使用 | 會顯示

    // 欄位屬性 [屬性名稱()]
    // 標題 Header
    // 提示 Tooltip
    // 範圍 Range
    */

    [Header("速度"), Tooltip("角色的移動速度"), Range(10, 1500)]
    public int speed = 50;
    [Header("血量"), Tooltip("這是角色的血量喔~"), Range(0, 1000)]
    public float hp = 999.9f;
    [Header("金幣數量"), Tooltip("儲存角色吃了幾顆金幣")]
    public int coin;
    [Header("跳躍高度"), Range(100, 2000)]
    public int height = 500;
    [Header("音效區域")]
    public AudioClip soundJump;
    public AudioClip soundSlide;
    public AudioClip soundHit;
    [Header("角色是否死亡"), Tooltip("True 代表死亡，False 代表尚未死亡")]
    public bool dead;
    #endregion

    #region 方法區域
    // C# 括號符號都是成對出現的：() [] {} "" ''
    private void Jump()
    {

    }

    private void Slide()
    {

    }

    private void Hit()
    {

    }

    private void EatCoin()
    {

    }

    private void Dead()
    {

    }
    #endregion
}
