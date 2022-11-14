using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{

    public List<GameObject> cubes = new List<GameObject>();
    private GameObject lastCube;


    // Start is called before the first frame update
    void Start()
    {
        SetLastCube();
    }

    private void SetLastCube()
    {
        lastCube = cubes[cubes.Count - 1];
    }

    public void AddCube(GameObject gameObject)
    {
        //kullanýcýyý yukarý taþý
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.044f, transform.position.z);
        //küpü yerleþtir
        gameObject.transform.position = new Vector3(lastCube.transform.position.x, lastCube.transform.position.y -0.044f, lastCube.transform.position.z);
        //küpü bloða dahil et
        gameObject.transform.SetParent(transform);
        cubes.Add(gameObject);
        SetLastCube();
    }

    public void RemoveCube(GameObject gameObject)
    {
        // küpü artýk oyuncuyla iliþkilendirme
        gameObject.transform.parent = null;
        // küpü bloktan kaldýr
        cubes.Remove(gameObject);
        //son küpü güncelle
        SetLastCube();
    }

/*
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wall")
        {
            Debug.Log("FAIL");

        }
    }
*/
}
