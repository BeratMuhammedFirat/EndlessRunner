using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public TileManager manager;

    private void OnTriggerEnter(Collider other)
    {
        manager.MoveTile();
        
    } 
}
