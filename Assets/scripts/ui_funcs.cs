using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui_funcs : MonoBehaviour
{
    //main screen ui functions

    //public functions
    public void quit_application()
    {
        //quit application
        Application.Quit();
    }

    public void play()
    {
        //play the AR experience
        SceneManager.LoadScene(1);
    }
}
