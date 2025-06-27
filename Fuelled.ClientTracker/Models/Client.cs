using System.ComponentModel.DataAnnotations.Schema;
namespace Fuelled.ClientTracker.Models;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime? StartDate { get; set; }
    public DateTime? RenewalDate { get; set; }
    public string PolicyTypesCsv { get; set; } = string.Empty;


    [NotMapped]
    public List<string> PolicyTypes
    {
        get => string.IsNullOrEmpty(PolicyTypesCsv)
               ? new List<string>()
               : PolicyTypesCsv.Split(',').ToList();
        set => PolicyTypesCsv = string.Join(',', value);
    }

    public OnboardingStage OnboardingStage { get; set; }
}

public enum OnboardingStage
{
    NotStarted,
    InProgress,
    Completed
}