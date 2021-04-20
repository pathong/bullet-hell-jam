using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObj : MonoBehaviour
{
    private AudioSource block_audio;
    private bool isDragging = true;
    private Vector3 player_pos;
    private bool canPlace;
    private Renderer rend;
    [SerializeField]
    private Color color = Color.red;
    private Collider2D playerColl;
    private GameObject player;
    private Collider2D myColl;


    // Start is called before the first frame update
    private void Start()
    {
        block_audio = gameObject.GetComponent<AudioSource>();
        myColl = gameObject.GetComponent<Collider2D>();
        myColl.enabled = false;
        player = GameObject.FindGameObjectWithTag("Player");
        playerColl = player.GetComponent<Collider2D>();
        rend = GetComponent<Renderer>();
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && canPlace)
        {
            block_audio.Play();
            isDragging = !isDragging;
        }
        player_pos = player.transform.position;
        if (Vector3.Distance(player_pos, transform.position) <= 2)
        {
            canPlace = true;
            rend.material.color = Color.white;
        }
        else
        {
            rend.material.color = color;
            canPlace = false;
        }
        if (isDragging)
        {
        
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePos);
        }
        if (!isDragging)
        {

            myColl.enabled = true ;
            this.enabled = false;
        }
    }
}
