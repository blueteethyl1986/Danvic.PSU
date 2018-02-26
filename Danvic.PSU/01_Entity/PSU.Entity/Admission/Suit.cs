﻿//-----------------------------------------------------------------------
// <copyright file= "Suit.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Date Created: 2018-02-19 20:37:17
// Modified by:
// Description: 制服信息表
//-----------------------------------------------------------------------
using PSU.Utility.System;
using System;
using System.ComponentModel.DataAnnotations;

namespace PSU.Entity.Admission
{
    public class Suit : SysField
    {
        #region Constructed Function

        public Suit()
        {
            SuitOID = Guid.NewGuid();
            Id = TimeUtility.GetTimespans();
            CreatedOn = DateTime.Now;
        }

        #endregion

        #region Attribute

        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public Guid SuitOID { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 上衣尺寸
        /// </summary>
        [MaxLength(20)]
        public string CoatSize { get; set; }

        /// <summary>
        /// 裤子尺寸
        /// </summary>
        [MaxLength(20)]
        public string PantsSize { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [MaxLength(500)]
        public string ImageSrc { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled { get; set; }

        #endregion
    }
}