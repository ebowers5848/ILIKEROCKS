using UnityEngine;
using UnityEngine.SceneManagement;  

public class LevelSelector : MonoBehaviour {
    public void Select(string levelName) {
        SceneManager.LoadScene(levelName);
    }

    public void Credits() {
        SceneManager.LoadScene("Credits");
    }

    public void Help() {
        SceneManager.LoadScene("Help");
    }
}
