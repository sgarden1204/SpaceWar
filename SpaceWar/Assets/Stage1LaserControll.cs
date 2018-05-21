using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1LaserControll : MonoBehaviour
{
    public bool INFINITE_LOOP = false; //if true, then duration is ignored
    public bool DESTROY_ON_END = false;
    public float duration = 2.0f;
    public ParticleSystem[] all_particles;

    public float moveSpeed = 1000.0f;
    public float controllMoveSpeed = 4000.0f;
    public float rotSpeed = 120.0f;
    public float moveControllValue = 1.0f;
    public float xPos = 1.0f;
    public float distance = 500.0f;
    public GameObject playerPos;
    private Vector3 move;

    private float start_time = -100.0f;
    private bool GO = true;

    // Use this for initialization
    void Start()
    {
        start_time = Time.time;
        this.transform.Rotate(0.0f, -90.0f, 0.0f);

        playerPos = GameObject.Find("PlayerPos");
    }

    // Update is called once per frame
    void Update()
    {
        if (!INFINITE_LOOP && duration + start_time <= Time.time && GO)
            StopAnimation();

        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");
        float amtRot = rotSpeed * Time.deltaTime;


        //if(Input.GetKeyUp(KeyCode.LeftArrow))
        //{
        //    xPos = -1000.0f;
        //}

        //else if(Input.GetKeyUp(KeyCode.RightArrow))
        //{
        //    xPos = 1000.0f;
        //}

        //else
        //{
        //    xPos = 0;
        //}

        //this.transform.position = playerPos.transform.position;
        //this.transform.position = new Vector3(playerPos.transform.position.x + xPos, playerPos.transform.position.y - xPos, playerPos.transform.position.z + distance);
        //this.transform.eulerAngles = new Vector3(playerPos.transform.rotation.x, playerPos.transform.rotation.y - 90.0f, playerPos.transform.rotation.z);
        //this.transform.Rotate(Vector3.up * hor * amtRot);

        this.transform.position = playerPos.transform.position;
        this.transform.position = new Vector3(playerPos.transform.position.x, playerPos.transform.position.y, playerPos.transform.position.z + distance);


        //move = new Vector3(hor * controllMoveSpeed * xPos, ver * controllMoveSpeed, moveSpeed);

        move = new Vector3(0.0f, ver * controllMoveSpeed * moveControllValue, moveSpeed);
        move = this.transform.TransformDirection(move);

        this.transform.Rotate(Vector3.up * hor * amtRot);
        this.transform.Translate(move * Time.deltaTime);
    }

    void StopAnimation()
    {
        for (int i = 0; i < all_particles.Length; i++)
        {
            all_particles[i].Stop();
        }
        GO = false;
        if (DESTROY_ON_END)
            Destroy(gameObject, 0.175f); //a little time before destroying, to let remaining particles die first.				
    }

    void PlayAnimation()
    {
        for (int i = 0; i < all_particles.Length; i++)
        {
            all_particles[i].Play();
        }
        start_time = Time.time;
        GO = true;
    }
}