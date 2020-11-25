using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    enum State {
        Idle,
        Chasing,
    }
    public GameObject target;
    public float speed = 2f;
    private State state = State.Idle;

    void Update()
    {
        switch (state) {
            case State.Idle:
                if (Input.GetKeyDown(KeyCode.Space)) {
                    state = State.Chasing;
                }
                break;
            case State.Chasing:
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
                if (Input.GetKeyDown(KeyCode.Space)) {
                    state = State.Idle;
                }
                break;
        }
    }
}
