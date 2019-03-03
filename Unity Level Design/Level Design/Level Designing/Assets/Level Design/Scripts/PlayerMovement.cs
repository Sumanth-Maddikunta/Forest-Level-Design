using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public float moveSpeed = 5.0f;
	public float rotateSpeed = 100.0f;
	public bool canMoveSideways=false;

	void Update()
	{
		Movement ();

	}



	void Movement()
	{    /*If we press Space bar the we can canMoveSideways
		can be true until Space bar is hold if 
			the space bar is released then it will
			be back to normal*/
		/*if (Input.GetKey (KeyCode.Space)) {
		canMoveSideways = true;
	}
	else 
	{
		canMoveSideways = false;
	}*/

	if (Input.GetKey (KeyCode.W)) 
	{
		Debug.Log ("Key Up Arrow is pressed");
		this.transform.Translate (new Vector3 (0, 0, moveSpeed * Time.deltaTime));

	}
	if (Input.GetKey (KeyCode.D)) 
	{    
		if (canMoveSideways) 
		{
			Debug.Log ("Key Right Arrow is pressed");
			this.transform.Translate (new Vector3 (moveSpeed * Time.deltaTime, 0, 0));
		}
		else
		{
			Debug.Log ("Key Right Arrow is pressed:Rotate)");
			this.transform.Rotate (new Vector3 (0,rotateSpeed * Time.deltaTime, 0));
		}


	} 
	if (Input.GetKey (KeyCode.A)) 
	{   
		if (canMoveSideways) 
		{
			Debug.Log ("Left arrow is pressed");
			this.transform.Translate (new Vector3 (-(moveSpeed * Time.deltaTime), 0, 0));
		}
		else
		{
			Debug.Log ("Key A is pressed(Anti-Clock wise)");
			this.transform.Rotate (new Vector3 (0, -rotateSpeed * Time.deltaTime, 0));
		}
	}
	if (Input.GetKey (KeyCode.S))
	{
		Debug.Log ("Down arrow is pressed");
		this.transform.Translate (new Vector3 (0, 0, -(moveSpeed * Time.deltaTime)));
	}
	if (Input.GetKey (KeyCode.Space)) 
	{
		Debug.Log ("Key W is pressed");
		this.transform.Translate (new Vector3 (0, moveSpeed * Time.deltaTime, 0));
	}
	if (Input.GetKey (KeyCode.S))
	{
		Debug.Log ("Key S is pressed");
		this.transform.Translate (new Vector3 (0, -moveSpeed * Time.deltaTime, 0));
	}
}

}
