using UnityEngine;

public class Customer : MonoBehaviour
{
    public string Order { get; private set; }

    public float MaxPatience = 10f;
    public float CurrentPatience { get; private set; }

    private bool isActiveCustomer;

    public void Initialize(string order)
    {
        Order = order;
        CurrentPatience = MaxPatience;
        isActiveCustomer = false;
    }

    public void SetActiveCustomer(bool isActive)
    {
        isActiveCustomer = isActive;
    }

    private void Update()
    {
        if (!isActiveCustomer)
        {
            return;
        }

        CurrentPatience -= Time.deltaTime;

        if (CurrentPatience <= 0f)
        {
            CurrentPatience = 0f;
            OrderManager.Instance.FailOrder();
        }
    }
}