//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// 
//  Author: Henry Rodriguez
// </auto-generated>
//------------------------------------------------------------------------------

namespace VL.Business.Services.Mapper
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    using VL.Business.Entities;
    using VL.Data.Model;
    
    /// <summary>
    /// DTO Mapper for <see cref="AssetHistory"/> and <see cref="AssetHistoryDTO"/>.
    /// </summary>
    static public partial class AssetHistoryMapper
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="AssetHistoryDTO"/> converted from <see cref="AssetHistory"/>.</param>
        static partial void OnDTO(this AssetHistory entity, AssetHistoryDTO dto);
       
        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="AssetHistory"/> converted from <see cref="AssetHistoryDTO"/>.</param>
        static partial void OnEntity(this AssetHistoryDTO dto, AssetHistory entity);
    
    
        /// <summary>
        /// Converts this instance of <see cref="AssetHistoryDTO"/> to an instance of <see cref="AssetHistory"/>.
        /// </summary>
        /// <param name="dto"><see cref="AssetHistoryDTO"/> to convert.</param>
        public static AssetHistory ToEntity(this AssetHistoryDTO dto)
        {
            if (dto == null) return null;
    
            var entity = new AssetHistory();
                 
            entity.ID = dto.ID;     
            entity.AssetID = dto.AssetID;     
            entity.ModifiedByUserID = dto.ModifiedByUserID;     
            entity.ModifiedDate = dto.ModifiedDate;     
            entity.AuditDate = dto.AuditDate;        
            dto.OnEntity(entity);
    
            return entity;
        }
    
        /// <summary>
        /// Converts this instance of <see cref="AssetHistory"/> to an instance of <see cref="AssetHistoryDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="AssetHistory"/> to convert.</param>
        public static AssetHistoryDTO ToDTO(this AssetHistory entity)
        {
            if (entity == null) return null;
    
            var dto = new AssetHistoryDTO();
                 
            dto.ID = entity.ID;     
            dto.AssetID = entity.AssetID;     
            dto.ModifiedByUserID = entity.ModifiedByUserID;     
            dto.ModifiedDate = entity.ModifiedDate;     
            dto.AuditDate = entity.AuditDate;
            entity.OnDTO(dto);
    
            return dto;
        }
    
        /// <summary>
        /// Converts each instance of <see cref="AssetHistoryDTO"/> to an instance of <see cref="AssetHistory"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<AssetHistory> ToEntities(this IEnumerable<AssetHistoryDTO> dtos)
        {
            if (dtos == null) return null;
    
            return dtos.Select(e => e.ToEntity()).ToList();
        }
    
        /// <summary>
        /// Converts each instance of <see cref="AssetHistory"/> to an instance of <see cref="AssetHistoryDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<AssetHistoryDTO> ToDTOs(this IEnumerable<AssetHistory> entities)
        {
            if (entities == null) return null;
    
            return entities.Select(e => e.ToDTO()).ToList();
        }
    
    }
}