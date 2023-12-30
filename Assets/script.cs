using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Abc",menuName ="Abc/Quiz")]
public class script : ScriptableObject
{

    public string name;
    public Dictionary<int, string> dict;
    public List<int> listType;
   
}
