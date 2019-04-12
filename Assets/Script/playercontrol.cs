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
else if (other.gameObject.layer == LayerMask.NameToLayer("enemies")){

KillPlayer();


}
else if (other.gameObject.layer == LayerMask.NameToLayer("forbidden")){

KillPlayer();



}



void KillPlayer() {


Camera.main.GetComponentInChildren<AudioSource>().mute = true;
scenemanager.instance.SetTapeSpeed(0);
audiomanager.instance.PlaySoundFail(gameObject);
sfxmanager.instance.ShowDieParticles(gameObject);
Destroy(gameObject);

}



}
}