using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAndMoveLaserControll : MonoBehaviour
{
    public bool INFINITE_LOOP = false; //if true, then duration is ignored
    public bool DESTROY_ON_END = false;
    public float duration = 2.0f;
    public ParticleSystem[] all_particles;

    public float moveSpeed = 1000.0f;
    public float controllMoveSpeed = 4000.0f;

    public float rotSpeed = 120.0f;
    public GameObject playerPos;
    public Transform myPos;
    private Vector3 move;

    private float start_time = -100.0f;
    private bool GO = true;

    // Use this for initialization
    void Start()
    {
        start_time = Time.time;
        this.transform.Rotate(0.0f, -90.0f, 0.0f);

        playerPos = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if (!INFINITE_LOOP && duration + start_time <= Time.time && GO)
            StopAnimation();

        this.transform.position = playerPos.transform.position;
        this.transform.position = new Vector3(playerPos.transform.position.x, playerPos.transform.position.y, playerPos.transform.position.z + 10.0f);
        //this.transform.eulerAngles = new Vector3(playerPos.transform.rotation.x, playerPos.transform.rotation.y, playerPos.transform.rotation.z);

        float rotLR = rotSpeed * Time.deltaTime;
        float rotTB = rotSpeed / 3.0f * Time.deltaTime;

        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        this.transform.Rotate(Vector3.up * hor * rotLR);
        this.transform.Rotate(Vector3.left * ver * rotLR);

        //move = new Vector3(hor * controllMoveSpeed, ver * controllMoveSpeed, 0.0f);

        //this.transform.Translate(move * Time.deltaTime);
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