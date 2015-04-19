using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update () {

        /////////////////////////////////////////////
        /// 移動 ////////////////////////////////////
        /////////////////////////////////////////////

        // 絶対値で指定（xyz単体ではなく、Vector3として指定する必要がある）
        //transform.position += new Vector3(-0.1f, 0.0f, 0.0f);

        // 相対値で指定（Vector3で指定）
        //transform.Translate(0.1f, 0.0f, 0.1f);

        // 相対値で指定（Vector3の定数を利用）
        //transform.Translate(Vector3.right * 0.1f);
        //transform.Translate(Vector3.forward * 0.1f);


        /////////////////////////////////////////////
        /// 入力 ////////////////////////////////////
        /////////////////////////////////////////////

        // 矢印キーで移動
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.position += new Vector3(x * 0.05f, 0.0f, 0.0f);
        transform.position += new Vector3(0.0f, 0.0f, z * 0.05f);

        //transform.Translate(x * 0.05f, 0.0f, 0.0f);
        //transform.Translate(0.0f, 0.0f, z * 0.05f);

	}

    // 衝突判定
    /*
    void OnCollisionEnter (Collision obj) {
        if (obj.gameObject.name == "leftwall")
        {
            Debug.Log("<color=green>Hit<LEFT>!!</color>");
        } else if (obj.gameObject.name == "rightwall") {
            Debug.Log("<color=green>Hit<RIGHT>!!</color>");
        }
        
    }
     */
}

