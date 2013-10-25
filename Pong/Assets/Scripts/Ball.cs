using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    private Vector3 direction;
    private Vector3 defPos;
	
	
	public Rigidbody ball;
	
	public GameObject paddle1;
	private Paddle paddle1Script;
	
	private float speed;
	
	//public Paddle paddle1;
		
	public bool go;
	
  
    // Use this for initialization
    void Start ()
    {
		paddle1Script = paddle1.GetComponent<Paddle>();
        this.direction = new Vector3(1.0f, 1.0f, 0).normalized;
        this.speed = .5f;
		
		go = false;
		defPos = this.transform.position;
//		defRot = this.transform.rotation;
		
		
				
    }
  
    // Update is called once per frame
    void Update ()
    {
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;
		if (Input.GetKeyDown(KeyCode.Space))
		{
			go = true;
		}
			
		if (go == true)
		{
	    this.transform.position += direction * speed;
		}
        
		
		if (this.transform.position.x > 30) 
 		{ 
 			ballReset();
		//	player1Paddle.pad1Reset();
		} 
 		
		if (this.transform.position.x < -30) 
 		{ 
			ballReset();
			//player1Paddle.pad1Reset();	
		}
    }
	
	void OnCollisionEnter(Collision collision)
    {
        Vector3 normal = collision.contacts[0].normal;
        direction = Vector3.Reflect(direction, normal);
    }
	
	public void ballReset()
	{
		go = false;
		//speed = speed * -1;
		//ball.transform.position = defPos;
		Instantiate(ball, new Vector3(0,0,0), Quaternion.identity);
		DestroyObject(gameObject);
		//DestroyObject(paddle1);
		
	}
	

}
