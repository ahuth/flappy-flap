using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdStuff : MonoBehaviour
{
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
}