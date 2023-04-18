using System.ComponentModel.DataAnnotations;

namespace Entrega1.Models.Data
{
    public enum CourseDifficulty
    {
        BASICO,
        INTERMEDIO,
        AVANZADO
    }

    public class Curso : BaseEntity
    { 
        [Required, StringLength(50)] public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)] public string ShortDescription { get; set; } = string.Empty;
        [Required] public string LongDescription { get; set; } = string.Empty;
        [Required] public string TargetAudience { get; set; } = string.Empty;
        [Required] public string Target { get; set; } = string.Empty;
        [Required] public string Requirements { get; set; } = string.Empty;
        [Required] public CourseDifficulty Difficulty { get; set; }
    }
}
