using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    public static CustomerManager Instance;

    public GameObject customerPrefab;
    public Transform[] queuePoints;
    public int maxQueueSize = 3;

    private readonly Queue<Customer> customerQueue = new Queue<Customer>();

    private void Awake()
    {
        Instance = this;
    }

    private IEnumerator Start()
    {
        yield return null;

        for (int i = 0; i < maxQueueSize; i++)
        {
            SpawnCustomer();
        }
    }

    public void SpawnCustomer()
    {
        if (customerQueue.Count >= maxQueueSize)
        {
            return;
        }

        int spawnIndex = customerQueue.Count;
        Transform spawnPoint = queuePoints[spawnIndex];

        GameObject customerObj = Instantiate(customerPrefab, spawnPoint.position, Quaternion.identity);
        Customer customer = customerObj.GetComponent<Customer>();

        customer.Initialize("Chicken Shawarma");
        customerQueue.Enqueue(customer);

        RefreshQueue();
    }

    public Customer GetFrontCustomer()
    {
        if (customerQueue.Count == 0)
        {
            return null;
        }

        return customerQueue.Peek();
    }

    public void RemoveFrontCustomer()
    {
        if (customerQueue.Count == 0)
        {
            return;
        }

        Customer frontCustomer = customerQueue.Dequeue();
        Destroy(frontCustomer.gameObject);

        RefreshQueue();
        SpawnCustomer();
    }

    private void RefreshQueue()
    {
        Customer[] customers = customerQueue.ToArray();

        for (int i = 0; i < customers.Length; i++)
        {
            customers[i].transform.position = queuePoints[i].position;
            customers[i].SetActiveCustomer(i == 0);
        }

        Customer frontCustomer = GetFrontCustomer();

        if (frontCustomer != null)
        {
            OrderManager.Instance.SetCustomer(frontCustomer);
            GameHUD.Instance.ShowStatus("Customer waiting for order");
        }
        else
        {
            GameHUD.Instance.ClearOrder();
        }
    }
}