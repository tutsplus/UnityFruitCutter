using UnityEngine;
using System.Collections;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject appleReference;
    private Vector3 throwForce = new Vector3(0, 18, 0);

    void Start()
    {
        InvokeRepeating("SpawnFruit", 0.5f, 6);
    }

    void SpawnFruit()
    {
        for (byte i = 0; i < 4; i++)
        {
            GameObject fruit = Instantiate(appleReference, new Vector3(Random.Range(10, 30), Random.Range(-25, -35), -32), Quaternion.identity) as GameObject;
            fruit.rigidbody.AddForce(throwForce, ForceMode.Impulse);
        }
    }
}