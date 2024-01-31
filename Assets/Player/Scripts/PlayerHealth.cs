using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{


    [SerializeField] private int maxHealth = 100;
    [SerializeField] GameObject damageTextPrefab;
    [SerializeField] IntEventChannel playerDamageChannel;
    int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }
    void OnEnable(){
        playerDamageChannel.OnEventRaised += takeDamage;
    }

    void OnDisable(){
        playerDamageChannel.OnEventRaised -= takeDamage;
    }
    void takeDamage(int damage){
        GameObject damageText = Instantiate(damageTextPrefab, transform.position, Quaternion.identity);
        currentHealth -= damage;
        if(currentHealth <= 0){
            damageText.GetComponent<DamageText>().popUp(damage.ToString() + "\nDEAD");
            Destroy(gameObject);
        }
        else 
            damageText.GetComponent<DamageText>().popUp(damage.ToString());

    }
}
