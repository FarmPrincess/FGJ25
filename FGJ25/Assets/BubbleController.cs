using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BubbleController : MonoBehaviour
{

	public float spawnTime = 3f;
	private Transform _bubble;


	// Use this for initialization
	void Start()
	{
		_bubble = GameObject.FindWithTag("Bubble").transform;

		InvokeRepeating("Bubble", spawnTime, spawnTime);

	}

	// Update is called once per frame
	void Update()
	{
		var step = 3.5f * Time.deltaTime;
		var target = new Vector3(_bubble.position.x, _bubble.position.y + 3, _bubble.position.z);
		transform.position = Vector3.MoveTowards(transform.position, target, step);
	}

	void SpawnBubble()
	{
		var newBubble = GameObject.Instantiate(_bubble);
	}
}
