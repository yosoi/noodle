namespace Noodle
{
  using UnityEngine;
  using UnityEngine.Events;

  public class TestTimer : MonoBehaviour
  {
    public float Duration;
    public UnityEvent OnExpire;

    private void OnEnable()
    {
      Invoke(nameof(Expire), Duration);
    }

    private void OnDisable()
    {
      CancelInvoke();
    }

    private void Expire()
    {
      OnExpire?.Invoke();
    }
  }
}
