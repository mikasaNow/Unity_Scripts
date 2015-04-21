using UnityEngine;
using System.Collections;

public class FreeCameraScript : MonoBehaviour {

	public float translationSpeed = 10.0f;
	public float rotationSpeed = 100.0f;
	public float zoomSpeed = 1000.0f;
	public float minFov = 10f;
	public float maxFov = 170f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float translation = Input.GetAxis("Vertical") * translationSpeed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		float zoom = Input.GetAxis ("Mouse ScrollWheel") * zoomSpeed;

		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		zoom *= Time.deltaTime;

		// 移動
		if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift)) {
			transform.Translate(0, translation, 0);
		} else {
			transform.Translate (0, 0, translation);
		}

		// 回転
		transform.Rotate(0, rotation, 0);

		// ズームイン／アウト
		float fov = GetComponent<Camera> ().fieldOfView;
		if (fov < minFov) {
			fov = minFov;
		} else if (fov > maxFov) {
			fov = maxFov;
		}
		GetComponent<Camera> ().fieldOfView = fov - zoom;


		// 簡易追従カメラとして利用する場合
		// カメラをtargetの子にする。targetに本スクリプトをアタッチする。
		// ズームイン／アウト
		/*
		Transform p = transform.FindChild ("Main Camera");
		float fov = p.GetComponent<Camera> ().fieldOfView;
		if (fov < minFov) {
			fov = minFov;
		} else if (fov > maxFov) {
			fov = maxFov;
		}
		p.GetComponent<Camera> ().fieldOfView = fov - zoom;
		*/
	}
}
