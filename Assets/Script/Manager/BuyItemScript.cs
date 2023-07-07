using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class BuyItemScript : MonoBehaviour
{
    public ItemDetails[] itemDetails;

   

   // public int amountToAdd;


 

    //public void BuyItem(int itemIndex)
    //{
    //    GameManager.instance.moneyText.text = itemDetails[itemIndex].itemPrice.ToString();

    //    if (GameManager.instance.moneyAmount > itemDetails[itemIndex].itemPrice)
    //    {
    //        GameManager.instance.moneyAmount -= itemDetails[itemIndex].itemPrice;
    //    }

    //    Debug.Log("Item " + itemIndex  + " " + "Purchased");
    //}



    [Serializable]
    public class ItemDetails
    {
        public int itemPrice;

        public int itemIndex;
        public GameObject item;
        public TextMeshProUGUI itemText;
         public int amountToAdd;
    }

}// End class...............










