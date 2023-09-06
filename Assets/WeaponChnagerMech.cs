using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class WeaponChnagerMech : MonoBehaviour
{
    public GameObject[] weaponArray;

    public int weaponNumer;
    public Image weaponImage;
   
    public TextMeshProUGUI bulletText;
    //public int bulletAmount;
    public GameObject currentWeapon;
   // public ShootingBehaviour refShootingBehav;
    public int activeWeapon;

    public Animator playerAnim;

    public bool ShotGun, Default, Riffle;
    private void Update()
    {
        ChnageWeapon();
       // bulletText.text = refShootingBehav.bulletCount.ToString();
    }

    public void ChnageWeaponSprite(int weponNum)
    {
        weaponImage.sprite = weaponArray[weponNum].GetComponent<ShootingBehaviour>().weaponImage;
        bulletText.text = weaponArray[weponNum].GetComponent<ShootingBehaviour>().bulletCount.ToString();
        activeWeapon = weponNum;
    }

    //public void AddBullet(int weponNum)
    //{
    //    refShootingBehav.bulletCount += weponNum;

    //}

    public void ChnageWeapon()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            weaponNumer++;
            if (weaponNumer > weaponArray.Length - 1)
            {
                weaponNumer = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            weaponNumer--;
            if (weaponNumer < 0)
            {
                weaponNumer = weaponArray.Length - 1;
            }
        }

       string nameParam= playerAnim.GetParameter(2 + weaponNumer).name;
      //  Debug.Log("ParamName=="+nameParam);
        playerAnim.SetBool(nameParam, true);

        #region new way of making parametr false....
        for (int i = 0; i < 5; i++)
        {
            if (i==2+weaponNumer)
            {
                continue;
            }
            playerAnim.SetBool(playerAnim.GetParameter(i).name, false);
        }
        #endregion

        #region  Old of of making Parameter false...
        //if (nameParam== "Default")
        //{
        //    playerAnim.SetBool("Riffle", false);
        //    playerAnim.SetBool("ShotGun", false);

        //}
        //if (nameParam == "Riffle")
        //{
        //    playerAnim.SetBool("Default", false);
        //    playerAnim.SetBool("ShotGun", false);

        //}
        //if (nameParam == "ShotGun")
        //{
        //    playerAnim.SetBool("Riffle", false);
        //    playerAnim.SetBool("Default", false);

        //}

        #endregion
        ChnageWeaponSprite(weaponNumer);

        currentWeapon = weaponArray[weaponNumer];
    }
}
