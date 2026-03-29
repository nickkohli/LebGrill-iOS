using UnityEngine;

public class Customer : MonoBehaviour
{
    public string Order { get; private set; }

    public float MaxPatience = 10f;
    public float CurrentPatience { get; private set; }

    public void Initialize(string order)
    {
        Order = order;
        CurrentPatience = MaxPatience;
    }

    private void Update()
    {
        CurrentPatience -= Time.deltaTime;

        if (CurrentPatience <= 0f)
        {
            CurrentPatience = 0f;
            OrderManager.Instance.FailOrder();
        }
    }
}