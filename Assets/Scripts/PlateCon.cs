using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateCon : MonoBehaviour
{
    private AudioSource _audio;
    public GameObject par;
    public GameObject blockWantTodisapper;
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
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "bullet")
        {
            _audio.Play();
            Instantiate(par, blockWantTodisapper.gameObject.transform.position, Quaternion.identity);
            blockWantTodisapper.SetActive(false);
        }
    }
}
