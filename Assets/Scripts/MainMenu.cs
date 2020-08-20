using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button playButton;

    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(PlayMaze);
    }

    // Update is called once per frame
    void Update() {    }

    // Loads the maze scene when the Play button is pressed
    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");
    }
}
