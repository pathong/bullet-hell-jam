using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTimeCon : MonoBehaviour
{
    public float slowTime = 0.2f;
    public bool isSlow = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartCoroutine(Slowmotion());
        }
    }
    IEnumerator Slowmotion()
    {
        Time.timeScale = slowTime;
        Time.fixedDeltaTime = slowTime * Time.deltaTime;
        yield return new WaitForSeconds(1);
        Time.timeScale = 1;
        Time.fixedDeltaTime = Time.deltaTime;
    }
}
