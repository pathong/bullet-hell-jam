using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulleet : MonoBehaviour
{
    private float timer = 10;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "block")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "ground")
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime * 8;
        }
        if (timer < 0)
        {
            Destroy(gameObject);
        }

    }
}
