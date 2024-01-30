using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
  //star is called before the first frame update
  Vector3 rotation;
  void Start()
  {
    var zRotation = Random.Range(0.1f, 0.3f);
  }
}
