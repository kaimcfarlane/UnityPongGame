using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 100.0f;
    private Rigidbody2D rigidbody;
    public AudioSource startAudio;
    // Start is called before the first frame update

    private void Awake () {
    rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start() {
        ResetPosition();
        AddStartingForce();
        startAudio.Play();

    }

    public void AddStartingForce() {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        Vector2 direction = new Vector2(x, y);
        rigidbody.AddForce(direction * this.speed);
        }

    public void AddForce(Vector2 force) {
        rigidbody.AddForce(force);
    }

    public void ResetPosition() {
        rigidbody.position = Vector3.zero;
        rigidbody.velocity = Vector3.zero;

        
    }
}
