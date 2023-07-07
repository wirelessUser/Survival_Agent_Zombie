using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    public GameObject[] LevelButtonsArray;
    public GameObject LevelPanel;
    public int currentLevel;
    private void Awake()
    {
        PlayerPrefs.DeleteAll();
        LevelManagerInactive();
        //.............................................................
         currentLevel = PlayerPrefs.GetInt("Current", 1);
        for (int i = 0; i < LevelButtonsArray.Length; i++)
        {
            
                LevelButtonsArray[i].gameObject.GetComponent<Button>().interactable = false;

            LevelButtonsArray[i].gameObject.GetComponent<Button>().GetComponent<Image>().color = new Color(0, 0, 0);

            if (i<currentLevel)
            {
                LevelButtonsArray[i].gameObject.GetComponent<Button>().interactable = true;
                LevelButtonsArray[i].gameObject.GetComponent<Button>().GetComponent<Image>().color = new Color(255, 255, 255);

            }
            
        }
    }



    public void LevelManagerActive()
    {
        LevelPanel.gameObject.SetActive(true);
    }
    public void LevelManagerInactive()
    {
        LevelPanel.gameObject.SetActive(false);
    }

    //.................................





}
