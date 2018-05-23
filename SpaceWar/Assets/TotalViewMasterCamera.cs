using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalViewMasterCamera : MonoBehaviour {

    [SerializeField] Transform target;
    [SerializeField] Vector3 distance = new Vector3(0.0f, 2.0f, -10.0f);
    [SerializeField] float distanceDamp = 10.0f;
    [SerializeField] float rotationDamp = 10.0f;

    Transform playerPos;

    //public Vector3 velocity = Vector3.one;

	// Use this for initialization
	void Start () {
        playerPos = this.transform;
	}

    private void LateUpdate()
    {
        Vector3 toPos = target.position + (target.rotation * distance);
        Vector3 curPos = Vector3.Lerp(playerPos.position, toPos, distanceDamp * Time.deltaTime);
        playerPos.position = curPos;

        Quaternion toRot = Quaternion.LookRotation(target.position - playerPos.position, target.up);
        Quaternion curRot = Quaternion.Slerp(playerPos.rotation, toRot, rotationDamp * Time.deltaTime);
        playerPos.rotation = curRot;
    }

    //// Update is called once per frame
    //void LateUpdate () {

    //       SmoothFollow();
    //}

    //   void SmoothFollow()
    //   {
    //       Vector3 toPos = target.position + (target.rotation * distance);
    //       Vector3 curPos = Vector3.SmoothDamp(playerPos.position, toPos, ref velocity, distanceDamp);
    //       playerPos.position = curPos;

    //       playerPos.LookAt(target, target.up);
    //   }
}
