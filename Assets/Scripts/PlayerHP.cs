using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHP : MonoBehaviour
{
    public float hp = 100;
    public Image healthBar;
    public Animator Ani;
    public Movement movementScript;

    void Start(){
        Ani = GetComponent<Animator>();
    }
       
    void Update()
    {
        hp = Mathf.Clamp(hp, 0, 100);

        healthBar.fillAmount = hp / 100;

        if (hp == 0){
            Invoke("DestroyPlayer", 8f);
            Ani.SetBool("die", true);
            Ani.SetBool("walk", false);
            Ani.SetBool("backwalk", false);
            Ani.SetBool("run", false);
            Ani.SetBool("pick", false);
            movementScript.enabled = false;
        }    
    }

    void DestroyPlayer(){
        Destroy(GameObject.FindGameObjectWithTag("Player"));
        SceneManager.LoadScene("DieScene");
    }
}
