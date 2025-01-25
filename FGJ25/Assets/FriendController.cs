using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendController : MonoBehaviour
{
    private Transform _player;

    void Start()
    {
        _player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        var step = 3.5f * Time.deltaTime;
        var target = new Vector3(_player.position.x, _player.position.y + 3, _player.position.z);
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }
}