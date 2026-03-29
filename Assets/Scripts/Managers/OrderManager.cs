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
        GameHUD.Instance.UpdateOrder(customer.Order);
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

        Destroy(currentCustomer.gameObject);
        currentCustomer = null;

        GameHUD.Instance.ClearOrder();
        GameHUD.Instance.UpdateUI();

        CustomerManager.Instance.SpawnCustomer();
    }

    public void FailOrder()
    {
        if (currentCustomer == null)
        {
            return;
        }

        Debug.Log("❌ Customer left due to impatience.");
        GameHUD.Instance.ShowStatus("Customer Left!");

        PopularityManager.Instance.AddPopularity(-3);

        Destroy(currentCustomer.gameObject);
        currentCustomer = null;

        GameHUD.Instance.ClearOrder();
        GameHUD.Instance.UpdateUI();

        CustomerManager.Instance.SpawnCustomer();
    }

    public Customer GetCurrentCustomer()
    {
        return currentCustomer;
    }
}