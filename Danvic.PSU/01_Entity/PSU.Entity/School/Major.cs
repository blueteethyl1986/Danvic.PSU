﻿//-----------------------------------------------------------------------
// <copyright file= "Major.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018-02-19 20:42:47
// Modified by:
// Description: 专业信息表
//-----------------------------------------------------------------------
using PSU.Entity.Dormitory;
using PSU.Utility.System;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSU.Entity.School
{
    public class Major : SysField
    {
        #region Constructed Function

        public Major()
        {
            MajorOID = Guid.NewGuid();
            Id = TimeUtility.GetTimespans();
            CreatedOn = DateTime.Now;
        }

        #endregion

        #region Attribute

        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid MajorOID { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// 专业名称
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        /// <summary>
        /// 所属院系名称
        /// </summary>
        [MaxLength(20)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 所在校区名称
        /// </summary>
        [MaxLength(20)]
        public string CampusName { get; set; }

        /// <summary>
        /// 专业代码
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 介绍
        /// </summary>
        [MaxLength(200)]
        public string Introduction { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled { get; set; }

        #endregion

        #region Foreign Key

        /// <summary>
        /// 院系主键
        /// </summary>
        public Guid DepartmentFK { get; set; }

        /// <summary>
        /// 校区主键
        /// </summary>
        public Guid CampusFK { get; set; }

        [ForeignKey("DepartmentFK")]
        public virtual Department Department { get; set; }

        [ForeignKey("CampusFK")]
        public virtual Campus Campus { get; set; }

        #endregion
    }
}