using UnityEngine;

public class OrderManager : MonoBehaviour
{
    public static OrderManager Instance;

    private Customer currentCustomer;

    private void Awake()
    {
        Instance = this;
    }

    public void SetCustomer(Customer customer)
    {
        currentCustomer = customer;

        if (currentCustomer != null)
        {
            GameHUD.Instance.UpdateOrder(currentCustomer.Order);
        }
        else
        {
            GameHUD.Instance.ClearOrder();
        }
    }

    public void CompleteOrder()
    {
        if (currentCustomer == null)
        {
            Debug.Log("No customer to serve.");
            return;
        }

        Debug.Log("✅ Order Completed Successfully!");
        GameHUD.Instance.ShowStatus("Order Completed!");

        EconomyManager.Instance.AddMoney(10);
        PopularityManager.Instance.AddPopularity(2);

        currentCustomer = null;

        GameHUD.Instance.UpdateUI();
        CustomerManager.Instance.RemoveFrontCustomer();
    }

    public void FailOrder()
    {
        if (currentCustomer == null)
        {
            return;
        }

        Debug.Log("❌ Order Failed, Customer left due to impatience!");
        GameHUD.Instance.ShowStatus("Customer Left!");

        PopularityManager.Instance.AddPopularity(-3);

        currentCustomer = null;

        GameHUD.Instance.UpdateUI();
        CustomerManager.Instance.RemoveFrontCustomer();
    }

    public Customer GetCurrentCustomer()
    {
        return currentCustomer;
    }
}