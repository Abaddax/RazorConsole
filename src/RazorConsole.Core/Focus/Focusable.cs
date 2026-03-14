// Copyright (c) RazorConsole. All rights reserved.

using System.Globalization;
using Microsoft.AspNetCore.Components;

namespace RazorConsole.Core.Focus;

public abstract class Focusable : ComponentBase
{
    protected readonly string _generatedFocusKey = Guid.NewGuid().ToString("N");

    /// <summary>
    /// Whether the input is disabled. When disabled, cannot receive focus or accept input.
    /// </summary>
    /// <remarks>
    /// When disabled, the input cannot receive focus or accept input.
    /// Default is <c>false</c>.
    /// </remarks>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// Tab order for keyboard navigation. Lower values receive focus first. If <c>null</c>, natural document order is used.
    /// </summary>
    [Parameter]
    public int? FocusOrder { get; set; }

    protected string FocusableAttribute => Disabled ? "false" : "true";
    protected string? FocusOrderAttribute => FocusOrder.HasValue
        ? FocusOrder.Value.ToString(CultureInfo.InvariantCulture)
        : null;
}
