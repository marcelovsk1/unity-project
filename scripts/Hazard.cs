using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour {

  Vector3 rotation;
  private void Start() {
   var xRotation = Random.Range(0.2f, 1f);
   rotation = new Vector3(1,0);
  }

  void private void Update() {
    transform.Rotate(rotation);
  }

  void private void OnCollisionEnter(Collision collision)
  {
    Destroy(gameObject);
  }
}
