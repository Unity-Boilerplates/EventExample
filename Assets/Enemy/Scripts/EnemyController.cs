using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform cannonEnd;

    [Range (0, 3)]
    [SerializeField] int fireRateInSeconds = 2;
    [SerializeField] float bulletForce = 30f;
    [SerializeField] float spotDistance = 10f;
    float timer;

    void Start(){
        timer = 0f;
    }


   

    // Update is called once per frame
    void FixedUpdate()
    {
       onPlayerSpotted(); 
    }

    void onPlayerSpotted(){
        Collider[] playerSpotted = Physics.OverlapSphere(transform.position, spotDistance);
        foreach (Collider enemy in playerSpotted){
            if(enemy.gameObject.tag == "Player"){
                transform.LookAt(enemy.transform);
                countDown();
            }
        }
    }
    void countDown(){
        timer += Time.fixedDeltaTime;
        if(timer >= fireRateInSeconds){
            shoot();
            timer = 0f;
        }
    }

   void shoot(){
       GameObject bullet = Instantiate(bulletPrefab, cannonEnd.position, cannonEnd.rotation);
       bullet.GetComponent<Rigidbody>().AddForce(cannonEnd.forward * bulletForce, ForceMode.Impulse);
   }

    void OnDrawGizmosSelected(){
        if (this.cannonEnd == null) return;
        Gizmos.DrawWireSphere(transform.position, this.spotDistance);
    }
}
