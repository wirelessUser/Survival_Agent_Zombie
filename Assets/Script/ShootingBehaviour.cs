using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehaviour : MonoBehaviour
{
    public bulletScript bulletPrefab;
    public Transform[] shootPOint;

    public float velocity=3;

    public float shotPerSeconds;
    public int bulletCount;
    public Sprite weaponImage;
    public int bulletShootTimeGap;
    public Animator ShootAnimator;


    private void Awake()
    {
        ShootAnimator = GetComponentInChildren<Animator>();
    }
    private void Update()
    {
        

    }

    public void CreateAndShootBullet()
    {
        //bulletScript bulletInst = Instantiate(bulletPrefab  , shootPOint.transform.position/*, shootPOint.transform.rotation*/);
        // bulletScript bulletInst = Instantiate(bulletPrefab, shootPOint.transform.position,bulletPrefab.transform.rotation);

        if (Time.time>shotPerSeconds && bulletCount>0)
        {
            ShootAnimator.SetTrigger("Shoot");
            shotPerSeconds = Time.time + bulletShootTimeGap;
            bulletCount--;
            foreach (Transform transfromPoint in shootPOint)
            {
                bulletScript bulletInst = Instantiate(bulletPrefab, transfromPoint.transform.position, transfromPoint.transform.localRotation);
                // bulletInst.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1*velocity);
                bulletInst.GetComponent<Rigidbody2D>().velocity = transfromPoint.transform.up * velocity;
            }
        }

       
       
    }



}
