using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdStuff : MonoBehaviour
{
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnFlap()
    {
        Rigidbody2D bird = GetComponent<Rigidbody2D>();
        bird.velocity = new Vector2(0, 10);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "pipe_gap") {
            score += 1;
            Debug.Log("score! " + score);
        }
    }
}
