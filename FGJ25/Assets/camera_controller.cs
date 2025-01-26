using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class camera_controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    //define player game object
    public GameObject player;

    // Update is called once per frame
    void LateUpdate()
    {
        //define start and end of level. 
        //This will detach the camera from the player until it enters the range again

        if (player.transform.position.y > 0f && player.transform.position.y < 50f)
        {
            transform.position = new Vector3(0f, player.transform.position.y, - 10f);
        }
    }
}
