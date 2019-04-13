using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class navigationmanager : MonoBehaviour


{
        public void LoadScene(string sceneName){
                
                SceneManager.LoadScene(sceneName);

        }
}
