

public class PickUpCoin : Pickup
{
    public override void PickMeUp()
    {
        Inventory.currentCoins++;
        UIManager.UpdateCoins();
        gameObject.SetActive(false);
    }
}
