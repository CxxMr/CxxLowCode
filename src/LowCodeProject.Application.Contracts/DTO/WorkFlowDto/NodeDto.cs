﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace LowCodeProject.Model.WorkFlow
{
    /// <summary>
    /// 节点表
    /// </summary>
    public class NodeDto : AuditedEntityDto<Guid>
    {
        public NodeDto()
        {
            IsDelete = false;
        }


        /// <summary>
        /// 节点编号
        /// </summary>
        public string NodeSN { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        public string NodeName { get; set; }

        ///// <summary>
        ///// 流程id
        ///// </summary>
        //public Guid? FlowId { get; set; }

        //[MaxLength(100)]
        ///// <summary>
        ///// 流程名称
        ///// </summary>
        //public string FlowName { get; set; }

        /// <summary>
        /// 执行人Id
        /// </summary>
        public Guid? OperatorId { get; set; }

        /// <summary>
        ///执行人名称
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 下一节点编号
        /// </summary>
        public string NextNodeSN { get; set; }

        /// <summary>
        /// 上一节点编号（退回节点）
        /// </summary>
        public string LastNodeSN { get; set; }



        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
