using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    public GameObject Levels;
    public GameObject StartButton;
    public GameObject ExitButton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        //Cursor.visible = false;
        //SceneManager.LoadScene(1);
        Levels.SetActive(true);
        StartButton.SetActive(false);
        ExitButton.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
