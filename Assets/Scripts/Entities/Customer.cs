using UnityEngine;

public class Customer : MonoBehaviour
{
    public string Order { get; private set; }

    public float MaxPatience = 10f;
    public float CurrentPatience { get; private set; }

    private bool isActiveCustomer;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Initialize(string order)
    {
        Order = order;
        CurrentPatience = MaxPatience;
        isActiveCustomer = false;

        ApplyRandomVisual();
    }

    public void SetActiveCustomer(bool isActive)
    {
        isActiveCustomer = isActive;

        if (spriteRenderer != null)
        {
            transform.localScale = isActive ? new Vector3(1.1f, 1.1f, 1f) : Vector3.one;
        }
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

    private void ApplyRandomVisual()
    {
        if (spriteRenderer == null)
        {
            return;
        }

        spriteRenderer.color = new Color(
            Random.Range(0.4f, 1f),
            Random.Range(0.4f, 1f),
            Random.Range(0.4f, 1f)
        );
    }
}