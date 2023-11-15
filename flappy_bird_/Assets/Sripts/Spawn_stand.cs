using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_stand : MonoBehaviour
{

    public GameObject stand;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            GameObject new_stand = Instantiate(stand, new Vector3(10, Random.Range(-3.5f, 3.9f), 0), Quaternion.identity);
            Destroy(new_stand, 10);
        }
    }





}
