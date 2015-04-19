using UnityEngine;
using System.Collections;


// ボールのrigidbodyに力を加える

public class BallContoller : MonoBehaviour {
	
	float speed = 20.0F;
	void Start () {
		// 2行で書く
		//Rigidbody exGC = GetComponent<Rigidbody>();
		//exGC.AddForce((transform.forward + transform.right ) * Speed, ForceMode.VelocityChange );

		// 1行で書く
		GetComponent<Rigidbody>().AddForce((transform.forward + transform.right ) * speed, ForceMode.VelocityChange );
	}

	void Update () {
	
	}
}
