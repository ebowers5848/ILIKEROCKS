using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameControl : MonoBehaviour {
    private bool paused = false;
    public TextMeshProUGUI pauseResumeButtonText;
    public GameObject audioGameObject;

    public void ResetGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PauseResumeGame() {
        if (paused) {
            // unpause
            Time.timeScale = 1;
            pauseResumeButtonText.text = "Pause";
            audioGameObject.GetComponent<AudioSource>().UnPause();
        } else {
            // pause
            Time.timeScale = 0;
            pauseResumeButtonText.text = "Resume";
            audioGameObject.GetComponent<AudioSource>().Pause();
        }
        paused = !paused;
    }
}
