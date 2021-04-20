using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private AudioSource _audio;
    private float time = 0f;
    public GameObject par;
    public GameObject portal;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        _audio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }                       

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            _audio.Play();
        }
    }
    private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.tag =="Player"){
            time += 1 * Time.deltaTime;

            
            
            if(time >= 1){

                Instantiate(par, transform.position, Quaternion.identity);
                player.transform.position =  new Vector2(portal.transform.position.x + 0.5f, portal.transform.position.y);

            }
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            time = 0f;
        }
    }

    // IEnumerator teleport(){

    // }                                            
}
