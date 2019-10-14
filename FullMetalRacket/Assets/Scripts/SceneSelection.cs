using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelection : MonoBehaviour
{

    //this is for the fade affect
   // public Animator anim;

    int levelToLoad;

    public int mainMenu;
    public int gameStart;
    Scene currentScreen;
    //and so on


    public void Start()
    {
        currentScreen = SceneManager.GetActiveScene();
        if (currentScreen.buildIndex == 0) FindObjectOfType<AudioManager>().Play("TitleTheme");
        if (currentScreen.buildIndex == 1)
        {
            FindObjectOfType<AudioManager>().Play("GameTheme");

        }
    }

    public void Update()
    {
    }

    public void LoadNextLevel()
    {
        levelToLoad = currentScreen.buildIndex + 1;
       // anim.SetTrigger("FadeOut");
    }

    public void ReloadLevel()
    { //this will find the GM and then reset some of the stats when it specifically reloads

        SceneManager.LoadScene(levelToLoad);
        levelToLoad = currentScreen.buildIndex;
       // anim.SetTrigger("FadeOut");
    }

    //for each level we have we need a method
    public void LoadGame()
    {
        Debug.Log("Button clicked");
        levelToLoad = gameStart; //the level to load;
        SceneManager.LoadScene(levelToLoad);
        FindObjectOfType<AudioManager>().Play("GameStart");
    }    

    public void QuitToMenu()
    {
        levelToLoad = mainMenu;
        //anim.SetTrigger("FadeOut");
        if (Time.timeScale != 1f)
        {
            Time.timeScale = 1f;
        }
    }

    public void QuitGame()
    {
        Debug.Log("Ejected");
        Application.Quit();
    }


    public void FadeToLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelToLoad);
    }


}