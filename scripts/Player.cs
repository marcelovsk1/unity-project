using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
  public float forceMultiplier = 5f;
  public float maximumVelocity = 2f;

  private Rigidbody rb;
  // Start is called before the first frame update;
  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    var horizontalInput = Input.GetAxis("Horizontal");

    if (GetComponent<Rigidbody>().velocity.magnitude <= 5f)
    {
      rb.AddForce(new Vector3(horizontalInput * forceMultiplier, 0, 0));
    }
  }
}
