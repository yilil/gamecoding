using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkButton : MonoBehaviour
{
    public GameObject Button;
    public GameObject talkUI;

    //private Transform player = GameObject.FindGameObjectWithTag("Player");

    private Rigidbody2D npc_body;


    private void OnTriggerEnter2D(Collider2D other)
    {
        Button.SetActive(true);
        transform.localScale = new Vector3(-1,1,0);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Button.SetActive(false);
        transform.localScale = new Vector3(1,1,0);
    }

    private void Update()
    {
        if (Button.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            talkUI.SetActive(true);
        }
    }

}
