using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public GameObject hazardPrefab;
  // Start is called before the first frame update
  public int maxHazardsToSpawn = 3;
  public TMPro.TextMeshPro scoreText;

  private int score;
  private float timer;
  private static bool gameOver;


  void Start()
  {
    StartCoroutine(SpawnHazards());
  }

  private IEnumerator SpawnHazards()
  {
    var hazardToSpawn = Random.Range(1, 4);

    for (int i = 0; i < hazardToSpawn; i++)
    {
      var x = Random.Range(-7 ,7);
      var drag = Random.Range(0f, 2f);

      var hazard = Instantiate(hazardPrefab, new Vector3(x, 11, 0), Quartenion.identity);
      hazard.GetComponent<Rigidbody>().drag = drag;
    }

    yield return new WaitForSeconds(1,5f);

    yield return SpawnHazards();
  }
}
