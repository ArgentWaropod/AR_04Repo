using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;

public class SpawnPuck : MonoBehaviour
{
    public TextMeshPro text;
    public int score;
    public GameObject near;
    public GameObject far;
    public GameObject prefab;
    List<GameObject> pucks;
    float position;

    private void Update()
    {
        text.text = score.ToString();
    }
    public void Play()
    {
        position = Random.Range(near.transform.position.x, far.transform.position.x);
        GameObject puck = Instantiate(prefab, new Vector3(position, near.transform.position.y, near.transform.position.z), Quaternion.identity);
        Destroy(puck, 10);
    }
    public void Restart()
    {
        score = 0;
    }
}
