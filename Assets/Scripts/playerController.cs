using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] private float mSpeed;
    private float mSpeedX, mSpeedY;
    private Rigidbody2D pBody;


    void Start()
    {
        pBody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        mSpeedX = Input.GetAxisRaw("Horizontal");
        mSpeedY = Input.GetAxisRaw("Vertical");
        pBody.velocity = new Vector2(mSpeedX* mSpeed, pBody.velocity.y);
        pBody.velocity = new Vector2(pBody.velocity.x,mSpeedY*mSpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(collision.gameObject);
            Debug.Log("Duvar ile temas edildi!");
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("triggerlendiniz!!");

    }
}
