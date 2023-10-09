using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoColeccionable : MonoBehaviour
{
    private AudioSource audioSouce;

    [SerializeField] private AudioClip colectar1;
    // Start is called before the first frame update
    void Start()
    {
        audioSouce = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Personaje"))
        {
            audioSouce.PlayOneShot(colectar1);
        }
    }
}
