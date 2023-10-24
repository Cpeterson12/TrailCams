
using UnityEngine;
[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int data;
    
    public void SetValue(int num)
    {
        data = num;
    }
  
    public void UpdateValue(int num)
    {
        data += num;
    }
}
