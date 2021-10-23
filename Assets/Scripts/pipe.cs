using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Move to the left.
        Rigidbody2D pipe = GetComponent<Rigidbody2D>();
        pipe.velocity = new Vector2(-7, 0);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnBecameInvisible()
    {
        enabled = false;
        Destroy(gameObject);
    }
}
