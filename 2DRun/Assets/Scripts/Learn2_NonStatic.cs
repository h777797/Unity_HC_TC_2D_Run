using UnityEngine;

public class Learn2_NonStatic : MonoBehaviour
{
    //儲存場景上物件或元件

    public GameObject zombie;

    public Transform zombieTran;

    public Camera Cam;

    public ParticleSystem ps;

    // 存取 非靜態屬性

    private void Start()
    {
        //取得
        print(zombie.tag);
        print(zombie.layer);

        //存放
        zombieTran.position = new Vector3(0, 7, 0);
        // zombieTran.localScale = new Vector3(1, 1, 1);
    }

    private void Update()
    {
        zombieTran.Translate(0.1f, 0, 0);
    }
}

