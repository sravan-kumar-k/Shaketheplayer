using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
    private Player player;

    void Start()
    {
        player = GetComponent<Player>();
    }

    void Update()
    {
        if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touch_Pos = Camera.main.ScreenToWorldPoint(touch.position);
            if(touch_Pos.x>0)
            {
                player.MoveRight();
            } if(touch_Pos.x<0)
            {
                player.MoveLeft();
            }

        }
    }
}
