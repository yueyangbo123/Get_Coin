using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float midTime;


    public AudioClip audioClip;


    // Start is called before the first frame update

    void FixedUpdate()
    {
        if (midTime > 15f)
        {
            Destroy(this.gameObject);
        }

        midTime += Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("发生碰撞：" + other.gameObject.tag);
        if (other.gameObject.tag.Equals("MainObj"))
        {
            //  _audioSource.Play();
            AudioSource.PlayClipAtPoint(audioClip, this.gameObject.transform.position);
            Destroy(this.gameObject);
        }
    }
}