using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public GameObject hazardPrefab;
  // Start is called before the first frame update
  void Start()
  {
    StartCoroutine(SpawnHazards());
  }

  private IEnumerator SpawnHazards()
  {
    var hazardToSpawn = Random.Range(1, 4);

    for (int i = 0; i < hazardToSpawn; i++)
  }
}
