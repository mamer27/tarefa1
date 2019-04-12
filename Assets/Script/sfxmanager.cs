using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfxmanager : MonoBehaviour
{
 public static sfxmanager instance = null;
 public GameObject coinparticles;
 public GameObject dieparticles;
 
 
 void Awake() {


if (instance == null) {

    instance = this;




}




 }

public void ShowCoinParticle(GameObject obj) {

    GameObject particles = Instantiate(coinparticles, obj.transform.position, Quaternion.identity);
    GameObject tape =  GameObject.Find("tape");
    particles.transform.SetParent(tape.transform);
}
public void ShowDieParticles(GameObject obj) {

    GameObject particles = Instantiate(dieparticles, obj.transform.position, Quaternion.identity);
    GameObject tape =  GameObject.Find("tape");
    particles.transform.SetParent(tape.transform);
}



}
