using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public float s;
    // Start is called before the first frame update
    private void Start()
    {
        // speed camera
        s = 0.1f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //высмчитываем позицию обьекта
        transform.position = new Vector3(transform.position.x - s, transform.position.y, 0);
    }
}
