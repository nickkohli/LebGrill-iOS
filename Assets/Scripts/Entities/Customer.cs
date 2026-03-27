using UnityEngine;

public class Customer : MonoBehaviour
{
    public string Order = "Chicken Shawarma";

    public void Initialize(string order)
    {
        Order = order;
    }
}