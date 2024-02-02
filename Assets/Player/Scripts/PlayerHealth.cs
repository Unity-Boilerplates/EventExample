using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerHealth : MonoBehaviour
{


    [SerializeField] IntVariable playerHealth;
    [SerializeField] IntVariable startingHealth;
    [SerializeField] GameObject damageTextPrefab;
    [SerializeField] GameEvent gameOverEvent;
    PlayerInput input;
    int currentHealth;


    void Start(){
        playerHealth.Value = startingHealth.Value;
        input = GetComponent<PlayerInput>();
        input.enabled = true;
    }

   
    public void takeDamage(int damage){
        GameObject damageText = Instantiate(damageTextPrefab, transform.position, Quaternion.identity);
        playerHealth.Value -= damage;
        if(playerHealth.Value <= 0){
            damageText.GetComponent<DamageText>().popUp(damage.ToString());
            input.enabled = false;
            gameOverEvent.Raise();
        }
        else 
            damageText.GetComponent<DamageText>().popUp(damage.ToString());

    }
}
