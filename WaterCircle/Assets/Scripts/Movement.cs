﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //variables
    public float moveSpeed = 300;
    public GameObject Character;

    private Rigidbody2D CharacterBody;
    private float ScreenWidth;


    // Use this for initialization
    void Start()
    {
        ScreenWidth = Screen.width;
        CharacterBody = Character.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        //loop over every touch found
        while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > ScreenWidth / 2)
            {
                //move right
                RunCharacter(1.0f);
            }
            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                //move left
                RunCharacter(-1.0f);
            }
            ++i;
        }
    }
    void FixedUpdate()
    {
#if UNITY_EDITOR
		RunCharacter(Input.GetAxis("Horizontal"));
#endif
    }

    private void RunCharacter(float horizontalInput)
    {
        //move player
        CharacterBody.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));
    }
}
