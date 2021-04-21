using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonCon : MonoBehaviour
{
    private float startTime = 0f;
    private float holdTime = 3.0f; // 3 seconds
    public Animator transitionAnim;

    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            startTime = Time.time;
            if (startTime + holdTime >= Time.time)
                ReStart();
        }
    }
    IEnumerator Quit()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSecondsRealtime(1.5f);
        Application.Quit();
    }
    IEnumerator LoadScene_i(int s)
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSecondsRealtime(1.5f);
        SceneManager.LoadScene(s);
    }
    IEnumerator LoadScene(string s)
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSecondsRealtime(1.5f);
        SceneManager.LoadScene(s);
    }
    public void t1()
    {
        StartCoroutine(LoadScene("s1"));
    }

    public void s_play()
    {
        StartCoroutine(LoadScene("Stage 1"));
    }
    public void s_opt()
    {
        StartCoroutine(LoadScene("Option"));
    }
    public void s_exit()
    {
        StartCoroutine(Quit());
    }
    public void s1()
    {
        StartCoroutine(LoadScene("1"));
    }
    public void s2()
    {
        StartCoroutine(LoadScene("2"));
    }
    public void s3()
    {
        StartCoroutine(LoadScene("3"));
    }
    public void s4()
    {
        StartCoroutine(LoadScene("4"));
    }
    public void s5()
    {
        StartCoroutine(LoadScene("5"));
    }
    public void s6()
    {
        StartCoroutine(LoadScene("6"));
    }
    public void s7()
    {
        StartCoroutine(LoadScene("7"));
    }
    public void s8()
    {
        StartCoroutine(LoadScene("11"));
    }
    public void s9()
    {
        StartCoroutine(LoadScene("9"));
    }
    public void s10()
    {
        StartCoroutine(LoadScene("10"));
    }
    
    public void s11()
    {
        StartCoroutine(LoadScene("8"));
    }
    
    public void s12()
    {
        StartCoroutine(LoadScene("12"));
    }
    
    public void s13()
    {
        StartCoroutine(LoadScene("13"));
    }
    public void s14()
    {
        StartCoroutine(LoadScene("14"));
    }
    public void s15()
    {
        StartCoroutine(LoadScene("15"));
    }
    public void ReStart()
    {
        StartCoroutine(LoadScene_i(SceneManager.GetActiveScene().buildIndex));
    }
    public void Home()
    {
        StartCoroutine(LoadScene("Menu"));
    }
    public void next(){
        StartCoroutine(LoadScene_i(SceneManager.GetActiveScene().buildIndex+1));
    }
    public void t5(){
        StartCoroutine(LoadScene("s5"));
    }
    public void t6()
    {   
        StartCoroutine(LoadScene("s6"));
    }

}

