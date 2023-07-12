
using UnityEngine;

public class PickUpLife : Pickup
{
    public override void PickMeUp()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().AddLife();
        gameObject.SetActive(false);
    }
}
