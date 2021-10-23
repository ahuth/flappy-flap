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

    void OnTriggerEnter2D()
    {
        // Create a new pipe. The only things moving on the screen are pipes, so we don't need to
        // check whether what actually collided here.
        Instantiate(pipePrefab, new Vector2(10, 2.5f), Quaternion.identity);
    }
}
