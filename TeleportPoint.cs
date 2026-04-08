using UnityEngine;

public class TeleportPoint : MonoBehaviour
{
    public Transform teleportPoint1;

    private void OnTriggerEnter(Collider other)
    {
    
    other.transform.position = teleportPoint1.position;

    
    
    }
    private void OnTriggerExit(Collider other)
    {




    }


}
