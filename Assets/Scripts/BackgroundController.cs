using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    MeshRenderer background;
    void Start()
    {
        background = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        Vector2 movimentImages = 1f * Time.deltaTime * Vector2.up;
        background.material.mainTextureOffset += movimentImages;
    }
}
