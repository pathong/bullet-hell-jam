using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class con2 : MonoBehaviour
{

    public Animator transitionAnim;
    // Start is called before the first frame update
    void Start()
    {



    }
    IEnumerator LoadScene_i(int s)
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSecondsRealtime(1.5f);
        SceneManager.LoadScene(s);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            StartCoroutine(LoadScene_i(0));
        }

    }
}
