using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObejctDestructionScript : MonoBehaviour
{
    public float  currenthealth, MaxHealth=100;
    private Animator carAnim;
    public GameObject explosionPrefab;
    private void Awake()
    {
        currenthealth = MaxHealth;
        carAnim = GetComponent<Animator>();
        AnimationStates();
    }

    public void DestroyVfx()
    {
        GameObject explos = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(explos);

    }


    public void AnimationStates()
    {
        if (currenthealth > 90)
        {
            Debug.Log("called if of car");
            carAnim.SetTrigger("carAnim_1");
        }

        if (currenthealth > 70 && currenthealth < 90)
        {
            carAnim.SetTrigger("carAnim_2");
        }

        if (currenthealth > 50 && currenthealth < 70)
        {
            carAnim.SetTrigger("carAnim_3");
        }

        if (currenthealth > 30 && currenthealth < 50)
        {
            carAnim.SetTrigger("carAnim_4");
            DestroyVfx();

        }

    }

    public void takeDamage(float damage)
    {
        currenthealth -= damage;
        Debug.Log("Current ehalth" + currenthealth);
        AnimationStates();


    }
}
