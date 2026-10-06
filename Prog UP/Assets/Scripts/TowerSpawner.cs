using UnityEngine;
using System.Collections;

public class TowerSpawner : MonoBehaviour
{

    [SerializeField] private GameObject Tower; 


    void Start()
    {
        Instantiate(Tower);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Tower);
        }
        
    }
}
