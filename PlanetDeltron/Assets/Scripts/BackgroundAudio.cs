using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudio : MonoBehaviour
{
    /*when scene starts our backgroundMusic object with tag GameMusic 
    wont be destroyed unless more than of that object are created
    This is used to play our background music across scenes 
    */
    private void Awake(){
        GameObject[] musicObject = GameObject.FindGameObjectsWithTag("GameMusic");
        if(musicObject.Length > 1){
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
 
}
