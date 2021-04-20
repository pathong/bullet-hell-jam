using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    public GameObject par;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "enemy_bullet" || col.gameObject.tag == "bullet")
        {
            Instantiate(par, transform.position, Quaternion.identity);
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
