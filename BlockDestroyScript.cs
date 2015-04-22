using UnityEngine;
using System.Collections;

public class BlockDestroyScript : MonoBehaviour {

	void Update () {
		if (this.gameObject == RayCameraScript.selectedGameObject) {
			Destroy(this.gameObject);
		}
	}
}
