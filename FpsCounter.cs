using UnityEngine;
using System.Collections;
using System.Text;

public class FpsCounter : MonoBehaviour {
	int frameCount;
	float nextTime;
	
	// Use this for initialization
	void Start () {
		nextTime = Time.time + 1;
	}
	
	// Update is called once per frame
	void Update () {
		frameCount++;
		
		if ( Time.time >= nextTime ) {
			// 1秒経ったらFPSを表示
			StringBuilder log = new StringBuilder();
			log.Append("FPS : <color=");
			if (frameCount >= 60) {
				log.Append("blue>");
			} else {
				log.Append("red>");
			}
			log.Append(frameCount);
			log.Append("</color>");

			Debug.Log(log.ToString());

			frameCount = 0;
			nextTime += 1;
		}
	}
}
