using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public AudioSource source;
    public AudioClip down;
    public AudioClip up;
    public AudioClip left;
    public AudioClip right;

    /* if statements that register key pressed to play certain clips we assign in the editor.
    We do this for all of our turns, slides, and jumps */
    void Update(){
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            source.PlayOneShot(down);
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)){
            source.PlayOneShot(up);
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            source.PlayOneShot(left);
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
            source.PlayOneShot(right);
        }
    }
}
