using UnityEngine;
using System.Collections;

public class BottomWallController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// 下壁にボールが振れた際にボールを削除
	void OnCollisionEnter(Collision col) {
		Destroy (col.gameObject);
	}
}
