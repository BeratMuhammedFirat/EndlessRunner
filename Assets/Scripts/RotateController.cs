using UnityEngine;

public class RotateController : MonoBehaviour
{
    public Vector3 rotate = new Vector3(0, 100, 0);
    public Transform[] dönecekTransform;


    void Update()
    {
        for(int i = 0; i < dönecekTransform.Length; i++)
        {
            if (dönecekTransform[i] != null)
            {
                dönecekTransform[i].Rotate(rotate * Time.deltaTime);
            }
            
        }

    }
}
