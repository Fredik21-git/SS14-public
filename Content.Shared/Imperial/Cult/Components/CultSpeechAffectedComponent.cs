using Robust.Shared.ViewVariables;

namespace Content.Shared.Imperial.Cult.Components;

/// <summary>
/// Помечает цель, поражённую заклинанием Стан культа.
/// Пока компонент активен — жертва периодически выкрикивает культовые фразы в радио.
/// </summary>
[RegisterComponent]
public sealed partial class CultSpeechAffectedComponent : Component
{
    /// <summary>Время, когда эффект заканчивается.</summary>
    [ViewVariables]
    public TimeSpan ExpiresAt;

    /// <summary>Время следующей принудительной культовой фразы.</summary>
    [ViewVariables]
    public TimeSpan NextPhrase;
}
