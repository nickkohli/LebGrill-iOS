using UnityEngine;

public class OrderManager : MonoBehaviour
{
    public string CurrentOrder = "Chicken Shawarma";

    public void CompleteOrder()
    {
        Debug.Log("Order Completed!");

        EconomyManager.Instance.AddMoney(10);
        PopularityManager.Instance.AddPopularity(2);

        GameHUD.Instance.UpdateUI();
    }
}