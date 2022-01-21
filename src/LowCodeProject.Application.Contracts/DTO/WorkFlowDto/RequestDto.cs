using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace LowCodeProject.Model.WorkFlow
{
    /// <summary>
    /// 请假申请
    /// </summary>
    public class RequestDto : AuditedEntityDto<Guid>
    {
        /// <summary>
        /// 请假原因
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 请假时长
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
