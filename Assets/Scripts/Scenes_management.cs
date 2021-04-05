using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes_management : MonoBehaviour
{
    int scene = 0;
    void load_next() { SceneManager.LoadScene(scene); }
    public void reload()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
        Invoke("load_next", 1f);
    }
    public void next()
    {
        scene = SceneManager.GetActiveScene().buildIndex + 1;
        Invoke("load_next", 3f);
    }
    public void Quit_game()
    {
        Application.Quit();
    }
}
