using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour


{
    public float speed = 10;
    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    // Move player based on arrow key input
    void MovePlayer()
    {
    horizontalInput = Input.GetAxis("Horizontal");
    transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }
}
