using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteOffset : MonoBehaviour
{
    Material sprites;
    
    void Start()
    {
        sprites = this.GetComponent<Material>();
    }

    void Update()
    {
        float x = Random.Range(0, 1) * 0.5f;
        float y = Random.Range(0, 1) * 0.5f;
        int name = Shader.PropertyToID("MainTextureOffset");
        sprites.SetTextureOffset(name, new Vector2(x, y));
    }
}
