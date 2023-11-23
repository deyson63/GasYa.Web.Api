namespace GasYa.Web.Api.Application.Commands;

public class UpdateUserDataCommand
{
    public int UserId { get; set; }
    public string NewName { get; set; }
    public string NewLastName { get; set; }
    public string NewEmail { get; set; }
}