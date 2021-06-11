using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorTest : MonoBehaviour
{

    public AudioClip horrorSound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "gameover")
        {
            other.gameObject.GetComponent<AudioSource>().PlayOneShot(horrorSound);
        }
    }
}
