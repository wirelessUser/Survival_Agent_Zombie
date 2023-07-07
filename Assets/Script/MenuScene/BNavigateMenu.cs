using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BNavigateMenu : MonoBehaviour
{
    public Button playButton;

    public string sceneName;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            PlayerPrefs.DeleteAll();
        }
    }
    private void Awake()
    {
        playButton = GameObject.Find("Play").GetComponent<Button>();
     

        playButton.onClick.AddListener(() => Play(sceneName));
       
    }


    public void Play(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

   
}
