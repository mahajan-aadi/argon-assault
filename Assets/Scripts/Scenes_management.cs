using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes_management : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        reload();
    }
    void load_next() { SceneManager.LoadScene(1); }
    public void reload()
    {
        Invoke("load_next", 4f);
    }
}
