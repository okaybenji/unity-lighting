using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinusoidalMove : MonoBehaviour {
  [SerializeField]
  float moveSpeed = 5f;

  [SerializeField]
  float frequency = 20f;

  [SerializeField]
  float magnitude = 0.5f;

  bool facingRight = true;

  Vector3 pos;

  // Start is called before the first frame update
  void Start() {
    pos = transform.position;
    Debug.Log("starting up the script... pos? " + pos);
  }

  // Update is called once per frame
  void Update() {
    CheckWhereToFace();

    if (facingRight) {
      MoveRight();
    } else {
      MoveLeft();
    }

    void CheckWhereToFace() {
      if (pos.z < -7f) {
        Debug.Log("turning right");
        facingRight = true;
      } else if (pos.z > 7f) {
        Debug.Log("turning left");
        facingRight = false;
      }
    }

    void MoveRight() {
      Debug.Log("moving right");
      pos += transform.forward * Time.deltaTime * moveSpeed;
//      transform.position = pos + transform.forward * Mathf.Sin(Time.time * frequency) * magnitude;
    }

    void MoveLeft() {
      Debug.Log("moving left");
      pos -= transform.forward * Time.deltaTime * moveSpeed;
//      transform.position = pos + transform.forward * Mathf.Sin(Time.time * frequency) * magnitude;
    }

    Debug.Log("updated pos: " + pos);
  }
}
