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
if (other.gameObject.CompareTag("gift")) {
    stopmusicandtape();
    audiomanager.instance.PlaySoundLevelComplete(gameObject);
    Destroy(gameObject);
    scenemanager.instance.Showpanel();
    
}

else if (other.gameObject.layer == LayerMask.NameToLayer("enemies")){

KillPlayer();


}
else if (other.gameObject.layer == LayerMask.NameToLayer("forbidden")){

KillPlayer();



}

void stopmusicandtape(){
Destroy(gameObject);
Camera.main.GetComponentInChildren<AudioSource>().mute = true;
scenemanager.instance.SetTapeSpeed(0);
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