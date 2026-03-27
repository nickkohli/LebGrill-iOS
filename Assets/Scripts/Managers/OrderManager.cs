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
            Debug.Log("No customer!");
            return;
        }

        Debug.Log("Order Completed: " + currentCustomer.Order);

        EconomyManager.Instance.AddMoney(10);
        PopularityManager.Instance.AddPopularity(2);

        Destroy(currentCustomer.gameObject);
        currentCustomer = null;

        GameHUD.Instance.UpdateUI();

        CustomerManager.Instance.SpawnCustomer();
    }
}