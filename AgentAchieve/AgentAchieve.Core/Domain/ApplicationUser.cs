using Microsoft.AspNetCore.Identity;

namespace AgentAchieve.Core.Domain;

/// <summary>
/// Represents an application user.
/// </summary>
public class ApplicationUser : IdentityUser
{
    /// <summary>
    /// Gets or sets the first name of the user.
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// Gets or sets the last name of the user.
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// Gets the full name of the user.
    /// </summary>
    public string? FullName
    {
        get
        {
            var parts = new List<string?>();
            if (!string.IsNullOrWhiteSpace(LastName))
            {
                parts.Add(LastName);
            }

            if (!string.IsNullOrWhiteSpace(FirstName))
            {
                parts.Add(FirstName);
            }

            return parts.Count != 0 ? string.Join(", ", parts) : UserName;
        }
    }

    /// <summary>
    /// Gets or sets the sales associated with the user.
    /// </summary>
    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();

    /// <summary>
    /// Gets or sets the sales goals associated with the user.
    /// </summary>
    public virtual ICollection<SalesGoal> SalesGoals { get; set; } = new List<SalesGoal>();
}
