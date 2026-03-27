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

    private void Start()
    {
        SpawnCustomer();
    }

    public void SpawnCustomer()
    {
        GameObject customerObj = Instantiate(customerPrefab, spawnPoint.position, Quaternion.identity);
        Customer customer = customerObj.GetComponent<Customer>();

        customer.Initialize("Chicken Shawarma");

        OrderManager.Instance.SetCustomer(customer);
    }
}