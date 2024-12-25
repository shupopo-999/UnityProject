using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class rot : MonoBehaviour
{
    public List<GameObject> obj;
    int id;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(Vector3.right * 0.1f);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            id = Random.Range(0, obj.Count);
            Instantiate(obj[id], new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
