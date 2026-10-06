using UnityEngine;

public class TowerBehaviour : MonoBehaviour
{

    void Start()
    {
        float x = Random.Range(0f, 1f);
        float y = Random.Range(0f, 1f);
        float z = Random.Range(0f, 1f);

        float a = Random.Range(-8f, 8f);
        float b = Random.Range(-8f, 8f);

        transform.localScale = new Vector3(x, y, z);
        transform.localPosition = new Vector3(a, y/2, b);
    }

}
