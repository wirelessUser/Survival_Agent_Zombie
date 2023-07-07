using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class GameManager : MonoBehaviour
{

    public static  GameManager instance;
    public GameObject BazaarPanel;
    public TextMeshProUGUI moneyText;
    public int moneyAmount;

    // Item refrences...............

    public BuyItemScript.ItemDetails[] itemDetails;
    public WeaponChnagerMech WeaponChnageRef;
    // public int amountToAdd;


    public void BuyItem(int itemIndex)
    {
        GameManager.instance.moneyText.text = itemDetails[itemIndex].itemPrice.ToString();

        if (GameManager.instance.moneyAmount > itemDetails[itemIndex].itemPrice)
        {
            GameManager.instance.moneyAmount -= itemDetails[itemIndex].itemPrice;
        }
        Debug.Log("Item " + itemIndex + " " + "Purchased");

        if (itemIndex==2)
        {
            WeaponChnageRef.weaponArray[WeaponChnageRef.activeWeapon].GetComponent<ShootingBehaviour>().bulletCount +=itemDetails[0].amountToAdd;
        }
    }

    private void Awake()
    {
       // BazaarPanel.SetActive(false);
        createInstance();
    }
    void createInstance()
    {
        if (instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    private void Update()
    {
        MoneyValue();
    }

    public void Resume()
    {
        BazaarPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void OpenBazaar()
    {
        BazaarPanel.SetActive(true);
        Time.timeScale =0;
    }


    public void MoneyValue()
    {
        moneyText.text = moneyAmount.ToString();
    }


  
}
