using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class healthManipulator : MonoBehaviour
{

    PlayerHP playerHP;

    public int amount;
    public float damageTime;
    float currentDamageTime;
    public TextMeshProUGUI escapeMessage;
    private static bool isTakingDamage = false;

    // Start is called before the first frame update
    void Start()
    {
        playerHP = GameObject.FindWithTag("Player").GetComponent<PlayerHP>();    
        if(escapeMessage != null){
            escapeMessage.gameObject.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other) {
        if(other.tag == "Player"){
            currentDamageTime += Time.deltaTime;
            if(currentDamageTime > damageTime){
                playerHP.hp += amount;
                currentDamageTime = 0.0f;
            }
            if(escapeMessage != null){
                escapeMessage.gameObject.SetActive(true);
                isTakingDamage = true;
            }
        }    
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "Player"){
            if(escapeMessage != null){
                escapeMessage.gameObject.SetActive(false);
            }
        }
    }
}
