using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnExit : MonoBehaviour
{
    public AudioSource audioPlayer;

    private void OnTriggerExit(Collider other)
    {
        audioPlayer.Play();
    }
}
