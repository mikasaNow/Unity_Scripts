using UnityEngine;
using System.Collections;

public class RayCameraScript : MonoBehaviour {

	public static GameObject selectedGameObject;
	
	void Update () {

		if (Input.GetMouseButton (0)) {
			Ray ray = GetComponent<Camera> ().ScreenPointToRay (Input.mousePosition);
			Debug.DrawRay (ray.origin, ray.direction * 10, Color.red);

			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 100)) {
				selectedGameObject = hit.collider.gameObject;
			} else {
				selectedGameObject = null;
			}
		}
	}
}
