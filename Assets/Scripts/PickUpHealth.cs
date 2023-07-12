
using UnityEngine;

public class PickUpHealth : Pickup
{
    public override void PickMeUp()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().AddHealth();
        gameObject.SetActive(false);
    }
}
