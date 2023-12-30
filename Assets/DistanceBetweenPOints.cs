using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceBetweenPOints : MonoBehaviour
{
    public GameObject redObj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculateDistance(this.gameObject.transform.position, redObj.transform.position);
      

    }

    private void CalculateDistance(Vector3 obj1,Vector3 obj2)
    {
        float dx = obj1.x - obj2.x;
        float dy = obj1.y - obj2.y;
        float dz = obj1.z - obj2.z;
        Debug.Log($"dx = {dx},dy = {dy},dz =  {dz}");
        Debug.Log(Mathf.Sqrt(dx * dx + dy * dy + dz * dz));
    }
}
