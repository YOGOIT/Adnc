﻿namespace Adnc.Application.Shared.Dtos
{
    /// <summary>
    /// OutputDto基类
    /// </summary>
    public interface IOutputDto<TKey> : IDto
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public TKey Id { get; set; }
    }
}