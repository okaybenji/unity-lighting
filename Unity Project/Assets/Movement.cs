using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

  [SerializeField]
  float distance = 1.5f;

  [SerializeField]
  float speed = 0.5f;

  Vector3 pos;
  int direction;

  // Start is called before the first frame update
  void Start() {
    direction = 1;
  }

  // Update is called once per frame
  void Update() {
    transform.Translate(Vector3.forward * Time.deltaTime * direction * speed);

    pos = transform.position;

    if (direction == 1 && pos.z > distance) {
      direction = -1;
    } else if (pos.z < -distance) {
      direction = 1;
    }
  }
}
