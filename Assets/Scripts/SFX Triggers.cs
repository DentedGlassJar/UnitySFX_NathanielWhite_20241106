using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXTriggers : MonoBehaviour
{
    public AudioSource MusicSFX;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MusicTrigger"))
        {
            MusicSFX.Pause();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MusicTrigger"))
        {
            MusicSFX.Play();
        }
    }
}
