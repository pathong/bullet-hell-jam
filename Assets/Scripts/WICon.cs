using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WICon : MonoBehaviour
{

 

    private bool isPause = false;
    public GameObject pauseUI;
    public GameObject winUI;
    public GameObject looseUI;
    // Start is called before the first frame update
    private void Awake()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        GameObject[] enemy_list;
        GameObject[] boss;
        GameObject[] bullet;
        GameObject[] e_bullet;
        bullet = GameObject.FindGameObjectsWithTag("bullet");
        e_bullet = GameObject.FindGameObjectsWithTag("enemy_bullet");




            

        if (GameObject.FindGameObjectWithTag("boss") == null && Time.timeScale == 1)
        {
            Time.timeScale = 0f;
            print(Time.timeScale);
            looseUI.active = true;

        }
        if (GameObject.Find("TImeCon").GetComponent<TImeCon>().timeRemaining == 0 && bullet.Length + e_bullet.Length == 0 && GameObject.FindGameObjectWithTag("boss") != null && Time.timeScale == 1)
        {
            winUI.active = true;
            print(Time.timeScale);
            Time.timeScale = 0f;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPause = !isPause;
            if (isPause)
            {
                pauseUI.active = true;
                Time.timeScale = 0f;
                print(Time.timeScale);
            }
            if (!isPause)
            {
                pauseUI.active = false;
                Time.timeScale = 1.0f;
                print(Time.timeScale);
            }
        }

    }
}
