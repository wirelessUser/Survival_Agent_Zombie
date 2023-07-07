using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneProgressMechanism : MonoBehaviour
{

   public int nextscene;

    public void LoadScene(int nextscene)
    {
        SceneManager.LoadScene(nextscene);
    }



    private void OnTriggerEnter2D(Collider2D collision)

    {

        PlayerPrefs.SetInt("Current", nextscene);
        Debug.Log("Next scene after setting" + nextscene);
        SceneManager.LoadScene("Main Menu");

    }

}
