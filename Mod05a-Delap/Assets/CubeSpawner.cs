using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefabVar;
    public GameObject spherePrefabVar;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject cubeGO = Instantiate(cubePrefabVar);
        Material cubeMat = cubeGO.GetComponent<Renderer>().material;
        cubeMat.color = Random.ColorHSV(0, 1, 0.5f, 1, 0.75f, 1);
        Object.Destroy(cubeGO, 1.5f);

        GameObject sphereGO = Instantiate(spherePrefabVar);
        Material sphereMat = sphereGO.GetComponent<Renderer>().material;
        sphereMat.color = Random.ColorHSV(0, 1, 0.5f, 1, 0.75f, 1);
        Object.Destroy(sphereGO, 1.5f);
    }
}
