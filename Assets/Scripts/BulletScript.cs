using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BulletScript : MonoBehaviour
{
    public float speed = 5f;
    public float deactivate_Timer = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DeactivateGameObject", deactivate_Timer);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;

    }

    void DeactivateGameObject()
    {
        gameObject.SetActive(false);
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        DeactivateGameObject();
    }
}
