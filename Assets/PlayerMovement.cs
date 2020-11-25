using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x + speed * Time.deltaTime * Input.GetAxis("Horizontal");
        float y = transform.position.y + speed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.position = new Vector3(x, y, 0f);
    }
}
