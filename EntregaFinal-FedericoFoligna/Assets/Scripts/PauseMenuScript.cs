using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    private bool pauseActive = false;
    public GameObject PauseMenu;
    public GameObject HudMenu;


    void Awake()
    {
        Time.timeScale = 1;        
    }
    // Update is called once per frame
    void Update()
    {
        togglePause();
    }

void togglePause()
{
    if (Input.GetKeyDown(KeyCode.Escape))
    {
        if(pauseActive)
        {
            resumeGame();
        }
        else
        {
            pauseGame();
        }
    }
}

public void resumeGame()
{
    PauseMenu.SetActive(false);
    HudMenu.SetActive(true);
    Time.timeScale = 1;
    pauseActive = false;
}

void pauseGame()
{
    PauseMenu.SetActive(true);
    HudMenu.SetActive(false);
    Time.timeScale = 0;
    pauseActive = true;
}

public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }


}
