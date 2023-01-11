using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // The object to follow
    public Transform target;

    // Speed at which the camera moves
    public float followSpeed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        // Keep the player in the center of the camera's view
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }
}
