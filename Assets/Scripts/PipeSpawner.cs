using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // Create a new pipe.
        if (collider.name == "pipe_top") {
            float valueY = Random.Range(0f, 5f);
            Instantiate(pipePrefab, new Vector2(10, valueY), Quaternion.identity);
        }
    }
}
