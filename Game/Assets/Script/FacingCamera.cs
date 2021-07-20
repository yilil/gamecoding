using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingCamera : MonoBehaviour
{
    Transform[] childs;

    private Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        childs = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            childs[i] = transform.GetChild(i);
        }
    }

    void Update()
    {
        for (int i = 0; i < childs.Length; i++)
        {
            if(childs[i].gameObject.layer == 5)
            {
                childs[i].position = player.position + new Vector3(0, 6.0f, 0);
            }
            childs[i].rotation = Camera.main.transform.rotation;
        }
    }
}
