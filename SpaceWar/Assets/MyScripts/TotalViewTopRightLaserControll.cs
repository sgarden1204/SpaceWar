using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalViewTopRightLaserControll : MonoBehaviour
{
    public bool INFINITE_LOOP = false; //if true, then duration is ignored
    public bool DESTROY_ON_END = true;
    public float duration = 0.5f;
    public ParticleSystem[] all_particles;

    public float controllMoveSpeed = 10.0f;
    public float highSpeed = 5.0f;

    public GameObject playerPos;
    private Vector3 move;

    private float start_time = -100.0f;
    private bool GO = true;

    // Use this for initialization
    void Start()
    {
        start_time = Time.time;
        this.transform.Rotate(0.0f, -90.0f, 0.0f);

        playerPos = GameObject.Find("TopPlayerPos");
    }

    // Update is called once per frame
    void Update()
    {
        if (!INFINITE_LOOP && duration + start_time <= Time.time && GO)
            StopAnimation();

        this.transform.position = playerPos.transform.position;
        this.transform.position = new Vector3(playerPos.transform.position.x - 1.0f, playerPos.transform.position.y, playerPos.transform.position.z - 1.0f);

        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            move = new Vector3(hor * controllMoveSpeed * highSpeed, ver * controllMoveSpeed * highSpeed, 0.0f);
        }

        else
        {
            move = new Vector3(hor * controllMoveSpeed, ver * controllMoveSpeed, 0.0f);
        }

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