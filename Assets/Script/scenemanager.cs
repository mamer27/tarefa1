using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenemanager : MonoBehaviour
{
    public static scenemanager instance = null;
    
    [SerializeField]
    private Vector3 TapeSpeed = new Vector3(-2f, 0f, 0f);
   
    [SerializeField]
    private Transform Tape = null;

    public uicomponents UIComponents;

    scenedata sceneData = new scenedata();


    void Awake() {
        if (instance == null) {

            instance = this;

        }


    }

    
    void Update()
    {
        Tape.position = Tape.position + TapeSpeed * Time.deltaTime;

        DisplayHudData();
    }



        public void Incrementcoincount() {

            sceneData.coincount++;




        }

        void DisplayHudData() {

        UIComponents.hud.txtcoincount.text = "x " + sceneData.coincount;

    }

}


