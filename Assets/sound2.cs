using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound2 : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource _audio;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "boss")
        {
            print("tag");
            _audio.PlayOneShot(clip);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        _audio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
