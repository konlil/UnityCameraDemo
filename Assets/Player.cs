using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10;
    public float turnSpeed = 60;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);
    }
}
