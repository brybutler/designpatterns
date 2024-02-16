namespace GangOf4Patterns.Behavioural.ChainOfResponsiblity.Models;

public class Document
{
    public string Title { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public bool ApprovedByLitigation { get; set; }

    public bool ApprovedByManagement { get; set; }

    public Document(string title, DateTime lastModifiedDate, bool approvedByLitigation, bool approvedByManagement)
    {
        Title = title;
        LastModifiedDate = lastModifiedDate;
        ApprovedByLitigation = approvedByLitigation;
        ApprovedByManagement = approvedByManagement;
    }
}