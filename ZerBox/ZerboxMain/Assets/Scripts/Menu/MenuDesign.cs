using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDesign : MonoBehaviour
{
    //public Material material;
    public float scrollspeed = 1f;
    public bool invert;
    public Renderer renderer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(invert == false)
        {
            renderer.material.mainTextureOffset = new Vector2(Time.time * scrollspeed * Time.deltaTime, 0f);
        }
        else
        {
            renderer.material.mainTextureOffset = new Vector2(0f, Time.time * scrollspeed * Time.deltaTime);
        }
    }
}
