using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBullet : MonoBehaviour
{

    public GameObject par;
    private Collider2D playerColl;
    private GameObject player;
    private AudioSource audio_;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy_bullet" || collision.gameObject.tag == "bullet" || collision.gameObject.tag == "spike")
        {
            Instantiate(par, transform.position, Quaternion.identity);
            audio_.Play();
            StartCoroutine(ded());
        }
    }
    //void OnTriggerEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "enemy_bullet" || collision.gameObject.tag == "bullet")
    //    {
    //        Destroy(gameObject);
    //    }
    //}
    // Start is called before the first frame update
    void Start()
    {
        audio_ = gameObject.GetComponent<AudioSource>();
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            playerColl = player.GetComponent<Collider2D>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreCollision(playerColl, GetComponent<Collider2D>(), true);
    }
    IEnumerator ded()
    {
        gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Destroy(gameObject);
    }
}
