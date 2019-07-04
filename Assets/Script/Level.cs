using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("Level");
    }
    public void StartBasic()
    {
        SceneManager.LoadScene("Episode");
    }
    public void StartFunction()
    {
        SceneManager.LoadScene("Episode2");
    }
    public void StartLoop()
    {
        SceneManager.LoadScene("Episode3");
    }
    public void Level1Game()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void Level2Game()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }
    public void Level3Game()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);

    }
    public void Level4Game()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);

    }
    public void Level5Game()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);

    }
    public void Level6Game()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);

    }
    public void Level7Game()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);

    }
    public void Level8Game()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);

    }

    public void BackToOpen()
    {
        SceneManager.LoadScene("menu");
    }

}
