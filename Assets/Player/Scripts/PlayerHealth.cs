using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{


    [SerializeField] IntVariable playerHealth;
    [SerializeField] IntVariable startingHealth;
    [SerializeField] GameObject damageTextPrefab;
    int currentHealth;


    void Start(){
        playerHealth.Value = startingHealth.Value;
    }

    public void takeDamage(Component sender, object data){
        GameObject damageText = Instantiate(damageTextPrefab, transform.position, Quaternion.identity);
        playerHealth.Value -= (int)data;
        if(playerHealth.Value <= 0){
            damageText.GetComponent<DamageText>().popUp(data.ToString());
            Destroy(gameObject);
        }
        else 
            damageText.GetComponent<DamageText>().popUp(data.ToString());

    }
}
