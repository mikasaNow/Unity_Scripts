using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BlockCreaterScript : MonoBehaviour {

    // Jump(スペース)押下時にBlockCreaterからBlockを生成

	public Transform BlockBlue;
	public Transform BlockYellow;
	public Transform BlockGrey;
	public Transform BlockRed;
	public Transform BlockGreen;

	private float widthMax = 2f;
	private float height = 0f;
	private float heightMax = 5f;
    private int blockNo = 0;
	private int blockNoMax = 4;
	private float dropInterval = 0.01f;
	private float elapsedTime = 0.0f;
	private Vector3 dropPoint = new Vector3(0 ,20 ,0);

	List<Transform> blockList = new List<Transform>();

	// Use this for initialization
	void Start () {
		blockList.Add (BlockBlue);
		blockList.Add (BlockYellow);
		blockList.Add (BlockGrey);
		blockList.Add (BlockRed);
		blockList.Add (BlockGreen);
	}
	
	// Update is called once per frame
	void Update () {

		if (elapsedTime > dropInterval && height < heightMax) {
			// 生成
			Instantiate (blockList[blockNo], dropPoint, Quaternion.identity);
			if (blockNo >= blockNoMax) {
				blockNo = 0;
			} else {
				blockNo++;
			}

			// dropPoint更新
			float x = dropPoint.x;
			float z = dropPoint.z;
			
			if (x > widthMax) {
				x = 0;
				if (z > widthMax) {
					z = 0;
					height += 0.5f;
				} else {
					z += 0.5f;
				}
			} else {
				x += 0.5f;
			}
			dropPoint = new Vector3(x , 20, z);



			elapsedTime = 0;
		} else {
			elapsedTime += Time.deltaTime;
		}
	}
}
