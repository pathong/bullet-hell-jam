using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roPlayer : MonoBehaviour
{
    GameObject[] player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
    }
    private void FixedUpdate()
    {
        if (player.Length > 0)
        {
            Vector3 diff = player[0].transform.position - transform.position;

            diff.Normalize();
            float rotationZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
        }

    }
}
