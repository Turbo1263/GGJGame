using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRocks : MonoBehaviour
{
    [SerializeField]
    private GameObject Gem1, Gem2;
    [SerializeField]
    private Transform pof1, pof2;

    private bool gem1Taken, gem2Taken;

    IEnumerator Spawn(GameObject gem, Transform pof) {
        yield return new WaitForSeconds(7.5f);
        GameObject gem1 = Instantiate(gem, pof.position, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject gem1 = Instantiate(Gem1, pof1.position, Quaternion.identity);
        GameObject gem2 = Instantiate(Gem2, pof2.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(gem1Taken == true) 
        {
            StartCoroutine(Spawn(Gem1, pof1));
        }
        if (gem2Taken == true) 
        {
            StartCoroutine(Spawn(Gem2, pof2));
        }
    }
}
