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

    public void resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void pause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void quitGame() {
        SceneManager.LoadScene(mainScene);
        PauseMenu.gameIsPaused = true;
        Time.timeScale = 1f;
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
