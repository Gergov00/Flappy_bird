using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_bird : MonoBehaviour
{
    public float force;

    public Rigidbody2D bird;
    public GameObject panel;




    // Start is called before the first frame update
    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    public void Move()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            bird.velocity = Vector2.up * force;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Stand")
        {
            Time.timeScale = 0;
            panel.SetActive(true);
        }
    }

}
