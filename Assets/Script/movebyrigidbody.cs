using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebyrigidbody : MonoBehaviour
{
    [SerializeField]

    private float SpeedFactor = 10f;

    [SerializeField]
    private Rigidbody2D Rb;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticallInput = Input.GetAxisRaw("Vertical");

        Rb.velocity = new Vector3(horizontalInput, verticallInput, 0f) * SpeedFactor;
    }
}
