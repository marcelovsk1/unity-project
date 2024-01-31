using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_2 : MonoBehaviour
{
  // Start is called before the first frame update
  Vector3 rotation;
  void Start()
  {
    var zRotation = Random.Range(0.01f, 0.05f);
    rotation = new Vector3(0, 0, -zRotation);
  }
}
