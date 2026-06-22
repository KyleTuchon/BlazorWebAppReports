using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebAppReports.Models;

public class Report
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public DateOnly DueDate { get; set; }

    public string? Type { get; set; }

    public string? Priority { get; set; }

    public string? AssignedTo { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public string? ImagePath { get; set; }
}