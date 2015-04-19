using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

    // 文字を表示

    public GUIStyle style;

    void OnGUI() {
        GUI.Label(new Rect(10.0f, 10.0f, 20.0f, 5.0f), "GameOver", style);
    }

}
