using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;

    public string verticalAxis;
    public string horizontalAxis;

    private void Update()
    {
        var ver = Input.GetAxis(verticalAxis);
        transform.position += transform.forward * speed * ver * Time.deltaTime;

        var hor = Input.GetAxis(horizontalAxis);
        transform.Rotate(0,rotateSpeed * hor * Time.deltaTime, 0);
    }
}
