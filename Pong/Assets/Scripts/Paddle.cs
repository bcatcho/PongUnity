using UnityEngine;
using System.Collections;

public class Paddle: MonoBehaviour {


    public KeyCode key_up;
    public KeyCode key_down;
	public Vector3 pad1DefPos;
	
	public GameObject ball;
	
	
	
	//GameObject paddle1;
	
	
 
    // Use this for initialization
    void Start () 
	{
		pad1DefPos = this.transform.position;
	//	paddle1 = this.gameObject;
		
		
	}
 
    // Update is called once per frame
    void Update () 
	{
		//
		if(Input.GetKeyDown(KeyCode.Space))
		{
			pad1Reset();
		}
 
    }
 
    void FixedUpdate() 
	{
        // get the current position
        Vector3 pos = transform.position;
		
		if (Input.GetKey(key_up)) 
        {
            // player wants to move the racket upwards
            transform.position = new Vector3(pos.x, 
                                             pos.y+ 0.5f, 
                                             pos.z );
        } 
        else if (Input.GetKey(key_down)) 
        {			
            // player wants to move the racket downwards
            transform.position = new Vector3(pos.x, 
                                             pos.y- 0.5f, 
                                             pos.z );
        }
    }
	
	public void pad1Reset()
	{
		this.transform.position = pad1DefPos;
		
	}
}