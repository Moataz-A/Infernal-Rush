﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    [SerializeField]
    private float objectSpeed = 1;
    [SerializeField]
    private float resetPosition = 33.0f;
    [SerializeField]
    private float startPosition = -32.59f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (!GameManager.instance.GameOver)
        {
            transform.Translate(Vector3.right * (objectSpeed * Time.deltaTime));
            if (transform.localPosition.x >= resetPosition)
            {
                Vector3 newPos = new Vector3(startPosition, transform.position.y, transform.position.z);
                transform.position = newPos;
            }
        }

    }
}
