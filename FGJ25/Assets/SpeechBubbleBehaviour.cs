using UnityEngine;

public class SpeechBubbleBehaviour : MonoBehaviour
{
    public GameObject Bubble;
    private bool Talks = false;

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player" && !Talks)
        {
            Talks = true;
            Instantiate(Bubble);
        }

    }
    // add void collision shit
    // when player jumps on top of fish, they say something

    // player controls?
    // on collision, call for Instantiate()

    // every fish has their own speechbubble
    // every bubble has their own static position and sprite

}
