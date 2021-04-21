using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlateEnd : MonoBehaviour
{
    public Animator end_anim;

    private AudioSource _audio;
    public GameObject par;

    public GameObject blockWantTodisapper;
    public GameObject blockWantTodisapper2;


    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _audio.Play();
            Instantiate(par, blockWantTodisapper.transform.position, Quaternion.identity);
            blockWantTodisapper.SetActive(false);
            StartCoroutine(end_game());
        }

    }
    IEnumerator end_game()
    {
        yield return new WaitForSecondsRealtime(2);
        Instantiate(par, blockWantTodisapper.transform.position, Quaternion.identity);
        blockWantTodisapper2.SetActive(false);
        yield return new WaitForSecondsRealtime(2);
        end_anim.SetTrigger("end");
        yield return new WaitForSecondsRealtime(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
