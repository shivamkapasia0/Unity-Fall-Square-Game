using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
   
    public float ballSpeed ;
    public AudioClip moveSound;
    public AudioClip pointSound;
    public AudioClip destroySound;
    public AudioSource audio;
    public float ballVelocity = 2;

    void Start()
    {

        audio = GetComponent<AudioSource>();
        
        ballSpeed = 1;
    }

    void Update()
    {
        /* For manual movement Left<->Right.
        transform.Translate(Vector3.right*Time.deltaTime*Input.GetAxis("Horizontal")*ballSpeed);
       */
        
        
        // For detecting touch & mouse click
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began || Input.GetMouseButtonDown(0))
       
        {
            audio.PlayOneShot(moveSound);
            if (ballSpeed == 1 )
            {
                ballSpeed = -1;
            }else 
            {
                ballSpeed = 1;
            }
            
        }
        // For changing ball direction w.r.t to end of container(line)---> +-x = 1.7
        
        else if (transform.position.x >=1.7)
        {
                      ballSpeed = -1;
                      audio.PlayOneShot(moveSound);
        }
        else   if (transform.position.x <= -1.7)
        {
            ballSpeed = 1;
            audio.PlayOneShot(moveSound);
        }
        
        // For changing direction of ball on x-axis..
        transform.Translate(ballSpeed * Time.deltaTime * ballVelocity,0,0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
           
            FindObjectOfType<GameOver>().onGameOver();
            
            // Destroying Player i.e ball
            audio.PlayOneShot(destroySound);
            Destroy(gameObject,0.1f);
            
            
            // Destroying Container of ball i.e line
            Destroy(GameObject.FindWithTag("Line"));
        }if (other.gameObject.CompareTag("Friend"))
        {
            Destroy(other.gameObject);
            audio.PlayOneShot(pointSound);
           
           
        }

       
    }
   
}
