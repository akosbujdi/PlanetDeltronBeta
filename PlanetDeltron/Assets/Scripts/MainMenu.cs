using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highestScore;
    //when game first starts, the record score will be set to 0
    public void Start(){
        PlayerPrefs.SetInt("highestScore", 0);
    }
    //record score will be updated using data stored with playerprefs on system
    public void Update(){
        highestScore.text = $"High Score: {PlayerPrefs.GetInt("highScore")}";
    }
    //changes scene on click to start game
    public void PlayGame()
    {
        SceneManager.LoadScene("StartGame");
     
    }
    //changes scene on click to about menu scene
    public void aboutMenu(){
        SceneManager.LoadScene("aboutMenu");

    }
    //changes scene on click to main menu
    public void mainMenu(){
        SceneManager.LoadScene("MainMenu");

    }
    //changes scene on click to the how to play scene
    public void howToMenu(){
        SceneManager.LoadScene("howToMenu");

    }
    //takes user to github repo
    public void OpenGit()
    {
        Application.ExternalEval("window.open(\"https://github.com/akosbujdi/PlanetDeltronBeta\")");
    }
    //on click function used to pause and resume music in the main menu 
    public void stopMusic(){
        AudioSource musicSource = GameObject.FindGameObjectWithTag("GameMusic").GetComponent<AudioSource>();
        musicSource.Pause();
    }
    public void resumeMusic(){
        AudioSource musicSource = GameObject.FindGameObjectWithTag("GameMusic").GetComponent<AudioSource>();
        musicSource.Play();
    }
}
