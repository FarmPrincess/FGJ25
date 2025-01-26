using UnityEngine;

public class SpeechBubbleBehaviour : MonoBehaviour
{
    public GameObject Bubble;
    public GameObject Bubble2;


    private bool Talks = false;
    private bool Text = false;
    private float creation;

    // Update is called once per frame
    void Update()
    {

        if (Time.time > creation +2 && !Text && Talks)
        {
            Text = true;
            Instantiate(Bubble2);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player" && !Talks)
        {
            Talks = true;
            Instantiate(Bubble);
            creation = Time.time;
        }

    }
    // add void collision shit
    // when player jumps on top of fish, they say something

    // player controls?
    // on collision, call for Instantiate()

    // every fish has their own speechbubble
    // every bubble has their own static position and sprite

}
