using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform player;

    public float smoothingSpeed;
    public Vector3 offset;
    float lastRotation;

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothingSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
        transform.LookAt(player.transform.position);
    }

    public void CameraRotate(float x)
    {
        offset = Quaternion.AngleAxis(x - lastRotation, Vector3.up) * offset;
        lastRotation = x;



    }



}
