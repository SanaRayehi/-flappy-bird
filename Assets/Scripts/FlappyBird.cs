using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public float speed = 2f;
    public float amount = 3f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * speed;
    }

   
    void Update()
    {
  
            if (Input.GetKeyDown(KeyCode.Space))
                BirdJump();
        
    }

    public void BirdJump()
    {
       
      rb.AddForce(Vector2.up * amount);
    }





void OnTriggerEnter2D(Collider2D other)
{
	
      if (other.transform.CompareTag("Obstacle"))
	{

		foreach (Transform child in other.transform.parent.transform)
		{
			child.gameObject.GetComponent<BoxCollider2D>().enabled = false;
		}
        rb.velocity = Vector2.zero;
    }
}


}