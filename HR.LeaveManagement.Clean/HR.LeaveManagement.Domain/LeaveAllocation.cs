using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain;
// to make scoped File scope namespace put semicolon in the end of namespace
public class LeaveAllocation : BaseEntity
{
    public int NumberOfDays { get; set; }
    public LeaveType? LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
    public string EmployeeId { get; set; } = string.Empty;
}
