using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour
{

    void Update()
    {
        Vector3 mousePos=Camera.main.ScreenToWorldPoint(new Vector3(
         Input.mousePosition.x,
         transform.position.y,
         transform.position.z));

        transform.position = new Vector3(
            Mathf.Clamp(mousePos.x, -2.5f, 2.5f),
            transform.position.y,
            transform.position.z);
    }
}
