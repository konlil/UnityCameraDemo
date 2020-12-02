using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAimCamera : MonoBehaviour
{
    public GameObject target;
    public float rotateSpeed = 5;
    Vector3 offset;
    bool cursorLocked = false;

    // Start is called before the first frame update
    void Start()
    {
        offset = target.transform.position - transform.position;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    Cursor.lockState = cursorLocked ? CursorLockMode.None : CursorLockMode.Locked;
        //    cursorLocked = !cursorLocked;
        //}
    }

    void LateUpdate()
    {
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.transform.Rotate(0, horizontal, 0);

        float desiredAngle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = target.transform.position - (rotation * offset);

        transform.LookAt(target.transform);
    }
}
