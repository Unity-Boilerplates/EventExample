using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateLifeNumber : MonoBehaviour
{
    [SerializeField] IntReference playerHealth;
    [SerializeField] TextMeshProUGUI lifeNumber;

    void Start()
    {
        lifeNumber.text = playerHealth.Value.ToString();
    }

    // Update is called once per frame
    public void Update(){
        if(playerHealth.Value <= 0) lifeNumber.text = "Game Over";
        else lifeNumber.text = playerHealth.Value.ToString();
    }
}
