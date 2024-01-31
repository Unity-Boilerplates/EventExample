using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
   [SerializeField] int damage = 10;
   [SerializeField] IntEventChannel playerDamageChannel;

    void OnCollisionEnter(Collision collision){
         if(collision.gameObject.tag == "Player"){
              playerDamageChannel.RaiseEvent(damage);
         }
        Destroy(gameObject);

    }
}
