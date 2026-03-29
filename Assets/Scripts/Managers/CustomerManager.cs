using System.Collections;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    public static CustomerManager Instance;

    public GameObject customerPrefab;
    public Transform spawnPoint;

    private void Awake()
    {
        Instance = this;
    }

    private IEnumerator Start()
    {
        yield return null;
        SpawnCustomer();
    }

    public void SpawnCustomer()
    {
        GameObject customerObj = Instantiate(customerPrefab, spawnPoint.position, Quaternion.identity);
        Customer customer = customerObj.GetComponent<Customer>();

        customer.Initialize("Chicken Shawarma");

        OrderManager.Instance.SetCustomer(customer);

        GameHUD.Instance.ShowStatus("Customer waiting for order");
    }
}