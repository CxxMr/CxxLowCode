using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowCodeProject.Model.WorkFlow
{
    /// <summary>
    /// 请假申请
    /// </summary>
    public class Request : AggregateRoot<Guid>
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
