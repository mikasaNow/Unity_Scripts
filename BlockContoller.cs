using UnityEngine;
using System.Collections;

public class BlockContoller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Blockにボールが振れた際にBlockを削除
	void OnCollisionEnter(Collision col) {
		Destroy (gameObject);
	}
}
