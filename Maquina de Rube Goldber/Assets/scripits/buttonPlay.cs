using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class buttonPlay : MonoBehaviour 
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void starMachine()
    {
        // Application.loadedLevel("Scenes/SampleScene");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/SampleScene");
    }

    public void showInstructions()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/InstrucitonsScene");
    }

    public void exitSimulation()
    {
        Application.Quit();
    }

    public void backToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/MenuScene");
    }
}
