using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnObj : MonoBehaviour
{
    private GameObject block_;

    public Text textShow;
    public GameObject block;
    public int count_block;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        textShow.text = count_block.ToString();
        if (count_block > 0 && Input.GetKeyDown(KeyCode.LeftShift))
        {
            Instantiate(block);
            count_block--;
        }

    }
}
