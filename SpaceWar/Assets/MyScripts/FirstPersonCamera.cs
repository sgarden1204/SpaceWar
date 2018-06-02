using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour {

    public GameObject targetPlayerPos;
    public GameObject masterCamera;

    public float cameraMoveSpeed = 20.0f;
    public float cameraControllMoveSpeed = 20.0f;
    public float cameraRotSpeed = 120.0f;

    private Vector3 cameraMove;

    private void Start()
    {
        //this.transform.Rotate(15.0f, 0.0f, 0.0f);
    }

    void LateUpdate () {

        //this.transform.Translate(0.0f, 0.0f, 20.0f * Time.deltaTime);

        this.transform.position = targetPlayerPos.transform.position;
        this.transform.rotation = targetPlayerPos.transform.rotation;

        masterCamera.transform.position = Vector3.zero;
        masterCamera.transform.eulerAngles = Vector3.zero;

        //this.transform.position = new Vector3(targetPlayerPos.transform.position.x, targetPlayerPos.transform.position.y + 5.0f, targetPlayerPos.transform.position.z - 3.0f);
        this.transform.position = new Vector3(targetPlayerPos.transform.position.x, targetPlayerPos.transform.position.y, targetPlayerPos.transform.position.z);

        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");
        float amtRot = cameraRotSpeed * Time.deltaTime;


        cameraMove = new Vector3(0.0f, ver * cameraControllMoveSpeed, cameraMoveSpeed);
        cameraMove = this.transform.TransformDirection(cameraMove);

        this.transform.Rotate(Vector3.up * hor * amtRot);
        this.transform.Translate(cameraMove * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0.0f);
        }
    }
}
