using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnterTrigger : MonoBehaviour
{
    public AudioSource audioPlayer;

    private void OnCollisionEnter(Collision collision)
    {
            audioPlayer.Play();
    }
}
