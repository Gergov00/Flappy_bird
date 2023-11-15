using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculate_core : MonoBehaviour
{

    public int score;
    public Text TextScore;


    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TextScore.text = $"Score: {score}";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Exp")
        {
            score++;
        }
    }

}
