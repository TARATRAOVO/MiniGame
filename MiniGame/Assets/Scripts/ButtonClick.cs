using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public GameObject MenuPausing;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void NewGame()
    {
        SceneManager.LoadScene("Testing Scene");
    }
    public void Continue()
    {
        SceneManager.LoadScene("Testing Scene");
    }
    public void ExitGame()
    {
        SceneManager.LoadScene("StartSCene");
    }
    public void Settings()
    {

    }
    public void Pause()
    {
        MenuPausing.SetActive(true);
    }

    public void ContinueInGame()
    {
        MenuPausing.SetActive(false);
    }
    public void Test()
    {
        print("TEST");
    }

    

}
