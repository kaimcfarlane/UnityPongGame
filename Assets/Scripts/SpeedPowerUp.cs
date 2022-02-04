using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject speedPowerUp;
    public Paddle playerPaddle;
    public Color myColor;
    public Renderer myRenderer;

    private void spawnPowerUp() {
    bool powerUpSpawn = false;
    while (!powerUpSpawn) {
        Vector3 powerUpPos = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
        if((powerUpPos - transform.position). magnitude < 3) {
          continue;
        }
        else {
          Instantiate(speedPowerUp, powerUpPos, Quaternion.identity);
          powerUpSpawn = true;
        }
    }
  }

  public void OnTriggerEnter2D(Collider2D collision) {
    Destroy(collision.gameObject);
    spawnPowerUp();
    Debug.Log("Target was hit");
    // Code Below is still being debugged
    // myRenderer.material.color = myColor;
  }

  void Start() {
      spawnPowerUp();
      myRenderer = playerPaddle.GetComponent<SpriteRenderer>();
  }

    // Update is called once per frame
    void Update()
    {
        
    }
}
