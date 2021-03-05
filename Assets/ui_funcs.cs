using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui_funcs : MonoBehaviour
{
    public void quit_application()
    {
        Application.Quit();
    }

    public void play()
    {
        SceneManager.LoadScene(1);
    }
}
