using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject player;
	//public Vector3 tada = Vector3(3,2,0);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void SpawnPlayer(){
				Instantiate (player, Vector3.zero , Quaternion.identity);
		}
}
