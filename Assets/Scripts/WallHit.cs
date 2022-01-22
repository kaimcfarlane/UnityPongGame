using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHit : MonoBehaviour
{
    public AudioSource hitSound;

    public void OnCollisionEnter2D(Collision2D collision) {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null) {
            hitSound.Play();
        }
    }
}
