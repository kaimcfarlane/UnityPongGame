using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public string mainScene;
    public AudioSource pauseSound;
    public AudioSource quitSound;
    public AudioSource resumeSound;

    public void resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        resumeSound.Play();
    }

    public void pause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        pauseSound.Play();
    }

    public void quitGame() {
        SceneManager.LoadScene(mainScene);
        PauseMenu.gameIsPaused = true;
        Time.timeScale = 1f;
        quitSound.Play();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if(gameIsPaused) {
                resume();
            }
            else {
                pause();
            }
        }
    }
}
