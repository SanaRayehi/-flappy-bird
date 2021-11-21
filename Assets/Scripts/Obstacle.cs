using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
	public GameObject ob;
	public float miny=.1f;
	public float maxy = 1.1f;
	public float mx = 1.2f;
	public int num = 100;



	// Update is called once per frame

	void start() { 
	Vector3 position =new Vector3();
	 for  (int i = 0; i<num ; i++){
		
			position.x = Random.Range(-mx, mx);
			position.y += Random.Range(miny, maxy);
			Instantiate(ob,position, Quaternion .identity);
		}
	}
 

}
