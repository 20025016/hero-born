using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Vector3 CameraOffset = new Vector3(0f, 1.2f, -2.6f);
    private Transform _target;

    private void Start()
    {
        _target = GameObject.Find("Player").transform;    
    }

    private void LateUpdate()
    {
        this.transform.position = _target.TransformPoint(CameraOffset);

        this.transform.LookAt(_target);
    }
}
