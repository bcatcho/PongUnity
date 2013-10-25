using UnityEngine;
using System.Collections;

public class aiPlayer: MonoBehaviour {

	
    public KeyCode key_up;
    public KeyCode key_down;
	public Vector3 pad2DefPos;

    public Transform tBall;
    GameObject Ball;
   
	GameObject paddle2;

    float nextMove;

    float moveDelay = .5f;

    float delayDelay = 5f;

 
    // Use this for initialization
    void Start () {
		pad2DefPos = this.transform.position;
		paddle2 = this.gameObject;
       

        

        nextMove = Time.time + moveDelay;
    }
 
    // Update is called once per frame
    void Update () {
        Ball = GameObject.FindGameObjectWithTag("ball");
        tBall = Ball.transform;
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    pad2Reset();
        //}
        if (Time.time > nextMove)
        {
            nextMove = Time.time + moveDelay;
            transform.position = new Vector3(pad2DefPos.x,
                                             tBall.transform.position.y,
                                            pad2DefPos.z);
        }
        
        //rigidbody.velocity = new Vector3(0, 0.2f,0);
 
    }
 
    void FixedUpdate() {
        // get the current position
        Vector3 pos = transform.position;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pad2Reset();
        }



        if (Input.GetKey(key_up))
        {
            // player wants to move the racket upwards
            transform.position = new Vector3(pos.x,
                                             pos.y + 0.5f,
                                             pos.z);
        }
        else if (Input.GetKey(key_down))
        {
            // player wants to move the racket downwards
            transform.position = new Vector3(pos.x,
                                             pos.y - 0.5f,
                                             pos.z);
        }
    }
	public void pad2Reset()
	{
		paddle2.transform.position = pad2DefPos;
		
	}
}