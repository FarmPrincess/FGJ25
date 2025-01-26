using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendController : MonoBehaviour
{
    private Transform _player;

    public BubbleBehaviour BubblePrefab;
    public Transform LaunchOffset;
    bool move;
    int i;

    void Start()
    {
        _player = GameObject.FindWithTag("Player").transform;
        move = true;

    }

    void Update()
    {
        if (move)
        {
            var step = 3f * Time.deltaTime;
            var pos = 2;
            if (_player.position.x > 0)
            {
                pos = -2;
            }
            var target = new Vector3(_player.position.x + pos, _player.position.y + 1, _player.position.z);
            transform.position = Vector3.MoveTowards(transform.position, target, step);
        }

        if (Time.time > i)
        {
            i += 1;
            LaunchOffset = transform;
            Instantiate(BubblePrefab, LaunchOffset);
        }
    }

    public void Stop ()
    {
        if (move)
        {
            move = false;
        } else
        {
            move = true;

        }

    }

}