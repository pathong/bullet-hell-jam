using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Vector3 cameraInitialPosition;
    public float shakeMagnetude = 0.1f, shakeTime = 0.5f;
    public Camera mainCamera;
    
    public GameObject par;
    private float timer = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "enemy")
    //    {

    //        Destroy(collision.gameObject);
    //        Destroy(gameObject);
    //    }
    //}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ground" || collision.gameObject.tag == "spike")
        {
            ShakeIt();
            Instantiate(par, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "block" )
        {
            ShakeIt();
            Instantiate(par, collision.gameObject.transform.position, Quaternion.identity);
            StartCoroutine(ded(collision.gameObject));
            Destroy(gameObject);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime * 6;
        }
        if (timer < 0)
        {
            Instantiate(par, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }

    public void ShakeIt()
    {
        cameraInitialPosition = Camera.main.transform.position;
        InvokeRepeating("StartCameraShaking", 0f, 0.005f);
        Invoke("StopCameraShaking", shakeTime);
    }

    void StartCameraShaking()
    {
        float cameraShakingOffsetX = Random.value * shakeMagnetude * 2 - shakeMagnetude;
        float cameraShakingOffsetY = Random.value * shakeMagnetude * 2 - shakeMagnetude;
        Vector3 cameraIntermadiatePosition = Camera.main.transform.position;
        cameraIntermadiatePosition.x += cameraShakingOffsetX;
        cameraIntermadiatePosition.y += cameraShakingOffsetY;
        Camera.main.transform.position = cameraIntermadiatePosition;
    }

    void StopCameraShaking()
    {
        CancelInvoke("StartCameraShaking");
        Camera.main.transform.position = cameraInitialPosition;
    }
    IEnumerator ded(GameObject objTodestroy)
    {
        objTodestroy.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        Destroy(objTodestroy);
    }
}
