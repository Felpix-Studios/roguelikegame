using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject settingsPanel;
    // Start is called before the first frame update
    void Start()
    {
        settingsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void exitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void openSettings(){
        settingsPanel.SetActive(true);
    }
    public void returnToMenu(){
        settingsPanel.SetActive(false);
    }
}