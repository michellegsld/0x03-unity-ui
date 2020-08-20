using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(PlayMaze);
        quitButton.onClick.AddListener(QuitMaze);
    }

    // Update is called once per frame
    void Update() {    }

    // Loads the maze scene when the Play button is pressed
    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");
    }

    // Closes the game window when Quit button is pressed
    public void QuitMaze()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
