using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_57 : MonoBehaviour
{
    public MeshRenderer mr;
    public float intensity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 1f, 0f);
    }

    void OnTriggerEnter(Collider col)
    {

   
        if (col.gameObject.name == "UFO") {
            mr.material.EnableKeyword("_EMISSION");
            float factor = Mathf.Pow(2, intensity);
            mr.material.SetColor("_EmissionColor", new Color(0f * factor, 0.5f * factor, 0.8f * factor));
        }
    }
}
