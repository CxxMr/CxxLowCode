﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowCodeProject.Model.WorkFlow
{
    public class FlowRecord : AggregateRoot<Guid>
    {
     
        /// <summary>
        /// 流程实例Id
        /// </summary>
        public Guid? WorkId { get; set; }

        /// <summary>
        /// 当前节点编号
        /// </summary>
        public string CurrentNodeSN { get; set; }

        /// <summary>
        /// 当前节点名称
        /// </summary>
        public string CurrentNode { get; set; }

        /// <summary>
        /// 操作人Id
        /// </summary>
        public Guid? OperatorId { get; set; }

        /// <summary>
        /// 操作人名称
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }


        /// <summary>
        /// 是否读取
        /// </summary>
        public bool IsRead { get; set; }

        /// <summary>
        /// 是否通过
        /// </summary>
        public bool IsPass { get; set; }

    }
}