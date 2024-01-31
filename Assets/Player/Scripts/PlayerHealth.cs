using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{


    [SerializeField] IntVariable playerHealth;
    [SerializeField] IntVariable startingHealth;
    [SerializeField] GameObject damageTextPrefab;
    [SerializeField] IntEventChannel playerDamageChannel;
    int currentHealth;

    void Start()
    {
        playerHealth.Value = startingHealth.Value;
    }
    void OnEnable(){
        playerDamageChannel.OnEventRaised += takeDamage;
    }

    void OnDisable(){
        playerDamageChannel.OnEventRaised -= takeDamage;
    }
    void takeDamage(int damage){
        GameObject damageText = Instantiate(damageTextPrefab, transform.position, Quaternion.identity);
        playerHealth.Value -= damage;
        if(playerHealth.Value <= 0){
            damageText.GetComponent<DamageText>().popUp(damage.ToString() + "\nDEAD");
            Destroy(gameObject);
        }
        else 
            damageText.GetComponent<DamageText>().popUp(damage.ToString());

    }
}
