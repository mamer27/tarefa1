using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{


void OnTriggerEnter2D(Collider2D other) {

if (other.gameObject.CompareTag("Coin")) {
    sfxmanager.instance.ShowCoinParticle(other.gameObject);
    audiomanager.instance.PlaySoundCoinPickup(other.gameObject);
    Destroy(other.gameObject);
    scenemanager.instance.Incrementcoincount();
}

}







}
