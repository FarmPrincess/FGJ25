using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BubbleBehaviour : MonoBehaviour
{

	public float speed = 0.3f;

	// Update is called once per frame
	void Update()
	{
		transform.Translate(Vector3.up * speed * Time.deltaTime);
	}

	//private void OnCollisionEnter2D(Collision2D collision)
	//{
	//	if (collision.gameObject.tag == "Player")
    //    {
	//		Destroy(gameObject);
    //    }
	//}
}
