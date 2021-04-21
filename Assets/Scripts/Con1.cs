using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Con1 : MonoBehaviour
{
    private Scene scene;
    public Animator transitionAnim;
    // Start is called before the first frame update
    void Start()
    {

        Scene scene = SceneManager.GetActiveScene();

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
            if(Input.GetKey(KeyCode.Mouse0))
            {
                return;
            }
            else
            {
                StartCoroutine(LoadScene_i(SceneManager.GetActiveScene().buildIndex + 1));
            }


        }

    }

    
}
