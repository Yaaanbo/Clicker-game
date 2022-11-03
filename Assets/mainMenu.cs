using Doozy.Runtime.UIManager.Animators;
using Doozy.Runtime.UIManager.Containers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public enum currentScene { _mainMenu, _gameplay};
    public currentScene _currentScene;
    public static mainMenu instance;
    public GameObject pausePanel;
    public GameObject pauseButton;
    public GameObject deadPanel;

    //private void Update()
    //{
    //    if(_currentScene == currentScene._mainMenu && Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        exitGame();
    //    }
    //    else if(_currentScene == currentScene._gameplay && Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        pause();
    //    }
    //}
    private void Awake()
    {
        instance = this;
    }
    public void play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("mainMenu");
        //Time.timeScale = 1;
    }

    public void pause()
    {
        Time.timeScale = 0;
        pauseButton.SetActive(false);
        //pausePanel.SetActive(true);
    }

    public void resume()
    {
        Time.timeScale = 1;
        //pausePanel.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void ded()
    {
        deadPanel.GetComponent<UIContainer>().Show();
        Time.timeScale = 0f;
    }
}
