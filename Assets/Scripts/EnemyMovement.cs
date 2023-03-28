using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//the variable ani, it is just used when we already have the animation, so it is not needed at this point
public class EnemyMovement : MonoBehaviour
{

    public int rutine;
    public float timer;
    public Animator ani;
    public Quaternion angle;
    public float grade;
    public AudioSource PassiveEnemy;
    public AudioSource AttackEnemy;

    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        PassiveEnemy.Play();
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        EnemyBehavior();
    }

    public void EnemyBehavior(){

        if(Vector3.Distance(transform.position, target.transform.position) > 5){

            ani.SetBool("run", false);
            timer += 1 * Time.deltaTime;
            AttackEnemy.PlayDelayed(1.0f);
            if(timer >= 4){
                rutine = Random.Range(0, 2);
                timer = 0;
            }
            switch (rutine){
                case 0:
                    //ani.SetBool("walk", false);
                    break;

                case 1:
                    grade = Random.Range(0, 360);
                    angle = Quaternion.Euler(0, grade, 0);
                    rutine++;
                    break;

                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angle, 0.5f);
                    transform.Translate(Vector3.forward * 2 * Time.deltaTime);
                    //ani.SetBool("walk", true);
                    break;
            }
        }
        else{
            var lookPos = target.transform.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 3);
            //ani.SetBool("walk", false);

            ani.SetBool("run", true);
            transform.Translate(Vector3.forward * 3 * Time.deltaTime);
        }

    }
}
