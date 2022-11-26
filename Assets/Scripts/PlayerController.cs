using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{

    public float speed = 5f;

    public float min_Y, max_Y;
    
    [SerializeField]
    private GameObject player_Bullet;
    
    [SerializeField]
    private Transform AttackPoint;
    
    public float attack_Timer = 0.35f;
    private float current_Attack_Timer;
    private bool canAttack;
    
    // Start is called before the first frame update
        void Start()
        {
            current_Attack_Timer = attack_Timer;

        }

        // Update is called once per frame
        void Update()
        {
            MovePlayer();
            Attack();
        }
        //The move player 
        void MovePlayer()
        {
            
            if (Input.GetAxisRaw("Vertical") > 0f)
            {
                Vector3 temp = transform.position;
                temp.y += speed * Time.deltaTime;

                //this stops the player from going out of bounds at the top of the screen
                if (temp.y > max_Y)
                    temp.y = max_Y;

                transform.position = temp;
            } 
            else if (Input.GetAxisRaw("Vertical") < 0f) 
            {
                Vector3 temp = transform.position;
                temp.y -= speed * Time.deltaTime;
                
                //this stops the player from going out of bounds at the top of the screen
                if (temp.y < min_Y)
                    temp.y = min_Y;

                transform.position = temp;
            }
            
        }

        void Attack()
        {
            attack_Timer += Time.deltaTime;
            if (attack_Timer > current_Attack_Timer)
            {
                canAttack = true;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow)) 
            {
                if (canAttack)
                {
                    canAttack = false;
                    attack_Timer = 0f;

                    Instantiate(player_Bullet, AttackPoint.position, Quaternion.identity);
                }
            }
        }// attack

    }// class
