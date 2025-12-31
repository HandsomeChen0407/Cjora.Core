using System.ComponentModel.DataAnnotations;

namespace Cjora.Core.Dto;

/// <summary>
/// 主键Id输入参数
/// </summary>
public class BaseIdInput
{
    /// <summary>
    /// 主键Id
    /// </summary>
    [Required(ErrorMessage = "Id不能为空")]
    [DataValidation(ValidationTypes.Numeric)]
    public virtual long Id { get; set; }

    /// <summary>
    /// 是否退押
    /// </summary>
    public bool IsRefundDeposit { get; set; }
}