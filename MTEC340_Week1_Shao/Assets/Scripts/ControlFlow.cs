using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    // 1) 
    public bool flag;

    void Start()
    {
        //
        if (flag)
        {
            Debug.Log("Boolean flag is set");
        }
        else
        {
            Debug.Log("Boolean flag isn't set");
        }

        //
        for (int i = 1; i <= 10; i++)
        {
            // 
            int value = (int)Mathf.Pow(2f, i);
            Debug.Log($"The {i} power of 2 is {value}");
        }

      
    }
}
