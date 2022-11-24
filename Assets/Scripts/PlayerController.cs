using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{

    public float speed = 5f;

    public float min_Y, max_Y;
    
    public float attack_Timer = 0.35f;
    private float current_Attack_Timer;
    private bool canAttack;
    
    [SerializeField]
    private GameObject player_Bullet;
    [SerializeField]
    private GameObject AttackPoint;

    
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            MovePlayer();
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

    }
