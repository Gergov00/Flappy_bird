using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_backgraound : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    private Transform back_Transform;
    private float back_size;
    private float back_pos;

    void Start()
    {
        back_Transform = GetComponent<Transform>();
        back_size = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        back_pos += speed * Time.deltaTime;
        back_pos = Mathf.Repeat(back_pos, back_size);
        back_Transform.position = new Vector3(-back_pos, 0, 0);
    }



}


