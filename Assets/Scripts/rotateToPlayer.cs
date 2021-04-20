using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateToPlayer : MonoBehaviour
{
    GameObject[] boss;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        boss = GameObject.FindGameObjectsWithTag("boss");
    }
    private void FixedUpdate()
    {
        if(boss.Length > 0)
        {
            Vector3 diff = boss[0].transform.position - transform.position;

            diff.Normalize();
            float rotationZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
        }
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
