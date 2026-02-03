using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpSpeed;
    public GameManager manager;

    public AudioClip jumpSound;
    public AudioClip dieSound;
    public AudioClip scoreSound;

    public AudioSource audioSource;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if ((Time.timeScale == 0))
        {
            return;
        }  
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up*jumpSpeed;
            audioSource.PlayOneShot(jumpSound);
        }

        if (-4.6f > transform.position.y || 4.4f < transform.position.y)
        {
            manager.endGame();
        } 
    }

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.CompareTag("column")){
            audioSource.PlayOneShot(dieSound);
            manager.endGame();
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("score"))
        {
            audioSource.PlayOneShot(scoreSound);
            manager.IncreaseScore();
        }
    }
}
