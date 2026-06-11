// ============================================================
// TOAST SERVICE — DentalClinic Blazor WASM
// Gestisce notifiche in-app accessibili (aria-live).
// Architettura predisposta per SignalR future integration.
// ============================================================

namespace DentalCLinic.Services;

public enum ToastType { Success, Error, Info, Warning }

public record ToastMessage(
    string Id,
    ToastType Type,
    string Title,
    string Body,
    int DurationMs = 5000
);

/// <summary>
/// Servizio per le notifiche toast.
/// Registrato come Scoped in Program.cs.
/// I componenti si abbonano a OnToastAdded e OnToastRemoved.
/// </summary>
public class ToastService
{
    private readonly List<ToastMessage> _toasts = new();

    public IReadOnlyList<ToastMessage> Toasts => _toasts.AsReadOnly();

    public event Action? OnChanged;

    public void ShowSuccess(string title, string body = "", int durationMs = 5000)
        => Add(ToastType.Success, title, body, durationMs);

    public void ShowError(string title, string body = "", int durationMs = 7000)
        => Add(ToastType.Error, title, body, durationMs);

    public void ShowInfo(string title, string body = "", int durationMs = 5000)
        => Add(ToastType.Info, title, body, durationMs);

    public void ShowWarning(string title, string body = "", int durationMs = 6000)
        => Add(ToastType.Warning, title, body, durationMs);

    private void Add(ToastType type, string title, string body, int durationMs)
    {
        var toast = new ToastMessage(
            Id: Guid.NewGuid().ToString("N")[..8],
            Type: type,
            Title: title,
            Body: body,
            DurationMs: durationMs
        );
        _toasts.Add(toast);
        OnChanged?.Invoke();
    }

    public void Dismiss(string id)
    {
        var toast = _toasts.FirstOrDefault(t => t.Id == id);
        if (toast is not null)
        {
            _toasts.Remove(toast);
            OnChanged?.Invoke();
        }
    }

    public void DismissAll()
    {
        _toasts.Clear();
        OnChanged?.Invoke();
    }
}
