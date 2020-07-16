using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade;
    private Rigidbody2D rb;
    public AudioSource fly;
    public GameObject gameOver;
    public AudioSource die;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * velocidade;
            fly.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D colisor) 
    {   
        die.Play();      
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
