using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject parentCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        parentCamera = GetComponentInParent<GameObject>();
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        transform.position = new Vector2((mousePosition.x - parentCamera.transform.position.x)/2, (mousePosition.y - parentCamera.transform.position.y) / 2);
        Debug.Log(parentCamera.transform.position.x);
        //rb.MovePosition(rb.position + (movement.normalized * (Time.fixedDeltaTime * SPEED)));
        //Vector3 direction = mousePosition - new Vector2(transform.position.x, transform.position.y);
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
