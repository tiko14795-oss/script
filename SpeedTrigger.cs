using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedfactor = 2.5f;
    public float jumpfactor = 5;

    private void OnTriggerEnter(Collider other)
    {
       other.GetComponent<FirstPersonMovement>().runSpeed *= speedfactor;
       other.GetComponent<Jump>().jumpStrength *= jumpfactor;
    }
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedfactor;
        other.GetComponent<Jump>().jumpStrength /= jumpfactor;
    }

}
