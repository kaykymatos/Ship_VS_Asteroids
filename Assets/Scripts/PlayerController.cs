using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(vertical *10f* Vector3.up * Time.deltaTime + horizontal * 10f * Vector3.right * Time.deltaTime);

    }
}
