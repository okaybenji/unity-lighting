using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensity : MonoBehaviour {

  [SerializeField]
  GameObject target;

  [SerializeField]
  float min;

  [SerializeField]
  float multiplier;

  Light light;

  // Start is called before the first frame update
  void Start() {
    light = GetComponent<Light>();
  }

  // Increase the light intensity as the door gets further from the spotlight (and vice versa)
  void Update() {
    float dist = Vector3.Distance(target.transform.position, transform.position);

    light.intensity = min + (dist * multiplier);
  }
}
