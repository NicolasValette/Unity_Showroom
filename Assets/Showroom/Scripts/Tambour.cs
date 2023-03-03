using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tambour : MonoBehaviour
{
    private AudioSource _drumSoundAudioSource;

    private void Start()
    {
        _drumSoundAudioSource= GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.CompareTag("Drumstick"))
        {
            Debug.Log("Boum");
            _drumSoundAudioSource.Play();
        }
    }
}
