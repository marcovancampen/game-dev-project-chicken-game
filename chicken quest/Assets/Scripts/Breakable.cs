using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public GameObject breakablePrefab;
    public GameObject brokenPrefab;
    private bool isBroken = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void ChangeModel()
    {
        if (!isBroken)
        {
            isBroken = true;
            breakablePrefab.SetActive(false);
            brokenPrefab.SetActive(true);
        }

    }
}
