
namespace BlogSite.Core.BaseEntity
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        string CreateBy { get; set; }
        DateTime CreateDate { get; set; }
    
        bool IsDelete { get; set; }
        string? ModifyBy { get; set; }
        DateTime? ModifyDate { get; set; }
    }
}