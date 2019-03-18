using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplemove : MonoBehaviour
{
    private float SpeedFactor =  1f;
    
    // Start is called before the first frame update
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticallInput = Input.GetAxisRaw("Vertical");
        
        Vector3  velocity = new Vector3(horizontalInput, verticallInput, 0f) * SpeedFactor;
        
        transform.position = transform.position + velocity * Time.deltaTime;
    }
}
