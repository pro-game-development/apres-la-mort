using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthManipulator : MonoBehaviour
{

    PlayerHP playerHP;

    public int amount;
    public float damageTime;
    float currentDamageTime;

    // Start is called before the first frame update
    void Start()
    {
        playerHP = GameObject.FindWithTag("Player").GetComponent<PlayerHP>();    
    }

    private void OnTriggerStay(Collider other) {
        if(other.tag == "Player"){
            currentDamageTime += Time.deltaTime;
            if(currentDamageTime > damageTime){
                playerHP.hp += amount;
                currentDamageTime = 0.0f;
            }
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
