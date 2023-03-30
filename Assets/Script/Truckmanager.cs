using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Truckmanager : MonoBehaviour
{
    public GameObject trunkPrefab;
    public GameObject branchLeftPrefab;
    public GameObject branchRightPrefab;
    private List<GameObject> brancher;
    private bool istoCreateEmpty = true;
    // Start is called before the first frame update
    void Start()
    {
        brancher = new List<GameObject>();
        for (int i = 0; i < 10; i += 2)
        {
            GameObject trunkEmpty = Instantiate(trunkPrefab);
            trunkEmpty.transform.parent = gameObject.transform;
            trunkEmpty.transform.localPosition = new Vector3(0, i * 1.43f, 0);
            brancher.Add(trunkEmpty);

            GameObject trunkBranch = Instantiate(getRandomBranch());
            trunkBranch.transform.parent = gameObject.transform;
            trunkBranch.transform.localPosition = new Vector3(0, (i + 1) * 1.43f, 0);
            brancher.Add(trunkBranch);
        }

    }
    private GameObject getRandomBranch()
    {
        int random = Random.Range(0, 100);
        if (random <= 10)
        {
            return trunkPrefab;
        }
        else if (random <= 55)
        {
            return branchLeftPrefab;
        }
        return branchRightPrefab;

    }
    public void cutFirstTruck()
    {
        Destroy(brancher[0]);
        brancher.RemoveAt(0);
        int i = 0;
        for (i = 0; i < brancher.Count; i++)
        {
            brancher[i].transform.localPosition = new Vector3(brancher[i].transform.localPosition.x, i * 1.43f, brancher[i].transform.localPosition.z);
        }
        GameObject trunkEmpty = Instantiate(istoCreateEmpty ? trunkPrefab : getRandomBranch());
        trunkEmpty.transform.parent = gameObject.transform;
        trunkEmpty.transform.localPosition = new Vector3(0, i * 1.43f, 0);
        brancher.Add(trunkEmpty);
        istoCreateEmpty = !istoCreateEmpty;


    }

    public string getDirectionFirstTruck()
    {
        return brancher[0].GetComponent<Truck>().direction;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReSet()
    {
        for (int i=0;i<brancher.Count;i++)
        {
            Destroy(brancher[i]);
        }
        brancher.RemoveRange(0, brancher.Count);
        Start();
    }
}
