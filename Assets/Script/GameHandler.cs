using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameHandler : MonoBehaviour
{
    public GameObject resultScreen;
    public GameObject ScoreUI;
    public GameObject ObjectiveUI;
    public GameObject PausedMenu;
    public static GameHandler GameHandlerInstance;
    private float timer  = 0;
    private bool GameIsPaused = false;

    public void ResultScreen(){
        resultScreen.SetActive(true);
        ScoreUI.SetActive(false);
        Time.timeScale = 0f;
        Debug.Log("You Won!");
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  
        Time.timeScale = 1f;
        Debug.Log("You Restarted the stage!");     
    }
    
    public void ReturnToTitleScreen(){
        SceneManager.LoadScene("Title Screen");
        Debug.Log("Loading to Title Screen.....");
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("Quitting Game...");
    }

    public void ResumeGame(){
        Time.timeScale = 1f;
        PausedMenu.SetActive(false);
        Debug.Log("Game is Unpaused!");
        GameIsPaused = false;
        ScoreUI.SetActive(true);
    }
    private void Awake()
    {
        GameHandlerInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 5){
            timer += Time.deltaTime;
        }
        else{
            ObjectiveUI.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused == false){
                Time.timeScale = 0f;
                PausedMenu.SetActive(true);
                Debug.Log("Game is Paused!");
                GameIsPaused = true;
                ScoreUI.SetActive(false);
            }
            else{
                Time.timeScale = 1f;
                PausedMenu.SetActive(false);
                Debug.Log("Game is Unpaused!");
                GameIsPaused = false;
                ScoreUI.SetActive(true);
            }
            
        }
    }
}
