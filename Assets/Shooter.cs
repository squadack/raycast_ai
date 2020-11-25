using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public float range = 8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 direction = (mousePos - transform.position).normalized; //wektor dlugosci 1
            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, range);
            if (hit.collider != null) {
                //trafilismy cos
                Debug.Log("Trafienie!");
                Debug.DrawLine(transform.position, hit.point, Color.red, 1f);
            }
            else {
                // pudło
                Debug.DrawLine(transform.position, transform.position + direction * range, Color.white, 1f);
            }
        }
    }
}
