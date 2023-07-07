using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyBerhaviour : MonoBehaviour
{
   public float currentHealth,maxhealth;
    
     float damageAmount;

    public Image fillImage;
    public float fillAmount = 100;
    public float totalFill=100;
    public Animator enemyAnim;
    private void Awake()
    {
        enemyAnim = GetComponent<Animator>();
        currentHealth = maxhealth;
    }
    private void Update()
    {
        fillAmount = currentHealth/totalFill ;
        fillImage.fillAmount = fillAmount;

        if (currentHealth<=0)
        {
            fillImage.fillAmount = 0;
        }
    }

    public void TakeDamage(float damageAmount)
    {

        currentHealth -= damageAmount;

        if (currentHealth<=0)
        {
            enemyAnim.SetBool("Dead", true);
            Destroy(gameObject,5);
        }
    }
}
