using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    // Start is called before the first frame update
    public float backgroundSpeed;
    public Renderer BackgroundRenderer;

    // Update is called once per frame
    void Update()
    {
        BackgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
