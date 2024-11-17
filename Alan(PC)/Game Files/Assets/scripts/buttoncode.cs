using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttoncode : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void playbutton()
    {
        SceneManager.LoadScene(1);
    }

    //pausebutton playermove ve player2move kodlarýnýn içinde.

    public void backbutton()
    {
        SceneManager.LoadScene(0);
    }

    public void quitbutton()
    {
        Application.Quit();
    }
}
