using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerBehaviour : MonoBehaviour
{
    public float currentHealth, maxhealth;
    public float moveHor, moveVert,moveSpeed;

    public Animator girlAnim;
    public Rigidbody2D girlBody;

    public Vector3 mousePos;
    public Vector3 dir;

    public ShootingBehaviour shootBehveRef;

    public float fillAmount;
    public Image fillBar;

    public bool isDead = false;

    public WeaponChnagerMech weponChnagerRef;
    private void Awake()
    {
        currentHealth = maxhealth;
        girlAnim = GetComponent<Animator>();

        girlBody = GetComponent<Rigidbody2D>();
        fillAmount = 100;

        Debug.Log("isDead" + isDead);
    }


    private void Update()
    {
        fillBar.fillAmount = currentHealth / fillAmount;


        if (!isDead)
        {

        
        if (currentHealth<=50)
        {
           // fillBar.sprite = null;
        }
        //  Player Movement...........................
        moveHor = Input.GetAxisRaw("Horizontal");
        moveVert = Input.GetAxisRaw("Vertical");


            PlayerMOve();



       // girlBody.MovePosition(new Vector2(moveHor , moveVert) * moveSpeed); // Not working  i think gravity is applying but postion is maintain at zero Due to 
       //  Zero moveHor and MoveVert;

            girlBody.MovePosition(girlBody.position + new Vector2(moveHor, moveVert) * moveSpeed*Time.deltaTime);

        //Player Follow Mouse Rotation.............................

        MouseFollow();

        //.............Shoot.................

        if (Input.GetMouseButtonDown(0))
        {
                weponChnagerRef.currentWeapon.GetComponent<ShootingBehaviour>().CreateAndShootBullet();
        }



}//if End

    }


    public void MouseFollow()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        dir = mousePos - transform.position;
        Vector3 normalVectorDir = dir.normalized;


        transform.up = new Vector3(normalVectorDir.x, normalVectorDir.y);
    }

    public void PlayerMOve()
    {
        girlAnim.SetBool("Default", false);
        girlAnim.SetBool("Riffle", false);
        girlAnim.SetBool("ShotGun", false);
        if (moveHor < 0 || moveVert < 0 || moveHor > 0 || moveVert > 0)
        {
            girlAnim.SetBool("Walk", true);
            girlAnim.SetBool("Default", false);
            girlAnim.SetBool("Riffle", false);
            girlAnim.SetBool("ShotGun", false);
        }
        else
        {
            // girlAnim.SetBool("Default", true);
            girlAnim.SetBool("Walk", false);
        }

    }

    public void TakeDamage(float damageAmount)
    {

        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            girlAnim.SetBool("Dead", true);
            isDead = true;
            Destroy(gameObject,3);
        }
    }
}
