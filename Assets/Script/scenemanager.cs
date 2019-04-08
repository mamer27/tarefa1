using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenemanager : MonoBehaviour
{
    
    [SerializeField]
    private Vector3 TapeSpeed = new Vector3(-4f, 0f, 0f);
    [SerializeField]
    private Transform Tape = null;

    public uicomponents UIcomponents;


    void Start()
    {
        
    }

    
    void Update()
    {
        Tape.position = Tape.position + TapeSpeed * Time.deltaTime;
    }
}
