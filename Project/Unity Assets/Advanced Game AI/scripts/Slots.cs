using UnityEngine;

public class Slots : MonoBehaviour
{
    public int melee;
    public GameObject meleePrefab;
    public GameObject leader;

    void Start()
    {
        int front = 2 * melee / 3;
        int rear = melee - front;
        createRow(front, -2f, meleePrefab);
        createRow(rear, -4f, meleePrefab);
    }

    void createRow(int num, float z, GameObject pf)
    {
        float pos = 1 - num;
        for (int i = 0; i < num; ++i) {
            Vector3 position = leader.transform.TransformPoint(new Vector3 (pos,0f,z));
            GameObject temp = (GameObject)Instantiate(pf, position, leader.transform.rotation); 
            temp.AddComponent<Formation>();
            temp.GetComponent<Formation>().pos = new Vector3 (pos,0,z);
            temp.GetComponent<Formation>().target = leader;
            pos += 2f;
        }
    }
}
