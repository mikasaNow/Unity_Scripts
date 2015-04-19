using UnityEngine;
using System.Collections;

public class BallBoxScript : MonoBehaviour {

    // Jump(スペース)押下時にBallBoxからBallを生成


    public Transform ball;
    private int count = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Jump")) {
            Instantiate(ball, new Vector3(Random.Range(-2, 2), transform.position.y, transform.position.z), transform.rotation);
            
            count++;
        }

        if (count > 10) {
            Application.LoadLevel("GameOver");
        }
	
	}
}
