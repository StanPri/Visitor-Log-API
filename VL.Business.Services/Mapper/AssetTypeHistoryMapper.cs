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
    /// DTO Mapper for <see cref="AssetTypeHistory"/> and <see cref="AssetTypeHistoryDTO"/>.
    /// </summary>
    static public partial class AssetTypeHistoryMapper
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="AssetTypeHistoryDTO"/> converted from <see cref="AssetTypeHistory"/>.</param>
        static partial void OnDTO(this AssetTypeHistory entity, AssetTypeHistoryDTO dto);
       
        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="AssetTypeHistory"/> converted from <see cref="AssetTypeHistoryDTO"/>.</param>
        static partial void OnEntity(this AssetTypeHistoryDTO dto, AssetTypeHistory entity);
    
    
        /// <summary>
        /// Converts this instance of <see cref="AssetTypeHistoryDTO"/> to an instance of <see cref="AssetTypeHistory"/>.
        /// </summary>
        /// <param name="dto"><see cref="AssetTypeHistoryDTO"/> to convert.</param>
        public static AssetTypeHistory ToEntity(this AssetTypeHistoryDTO dto)
        {
            if (dto == null) return null;
    
            var entity = new AssetTypeHistory();
                 
            entity.ID = dto.ID;     
            entity.AssetTypeID = dto.AssetTypeID;     
            entity.Code = dto.Code;     
            entity.Name = dto.Name;     
            entity.ModifiedByUserID = dto.ModifiedByUserID;     
            entity.ModifiedDate = dto.ModifiedDate;     
            entity.AuditDate = dto.AuditDate;        
            dto.OnEntity(entity);
    
            return entity;
        }
    
        /// <summary>
        /// Converts this instance of <see cref="AssetTypeHistory"/> to an instance of <see cref="AssetTypeHistoryDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="AssetTypeHistory"/> to convert.</param>
        public static AssetTypeHistoryDTO ToDTO(this AssetTypeHistory entity)
        {
            if (entity == null) return null;
    
            var dto = new AssetTypeHistoryDTO();
                 
            dto.ID = entity.ID;     
            dto.AssetTypeID = entity.AssetTypeID;     
            dto.Code = entity.Code;     
            dto.Name = entity.Name;     
            dto.ModifiedByUserID = entity.ModifiedByUserID;     
            dto.ModifiedDate = entity.ModifiedDate;     
            dto.AuditDate = entity.AuditDate;
            entity.OnDTO(dto);
    
            return dto;
        }
    
        /// <summary>
        /// Converts each instance of <see cref="AssetTypeHistoryDTO"/> to an instance of <see cref="AssetTypeHistory"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<AssetTypeHistory> ToEntities(this IEnumerable<AssetTypeHistoryDTO> dtos)
        {
            if (dtos == null) return null;
    
            return dtos.Select(e => e.ToEntity()).ToList();
        }
    
        /// <summary>
        /// Converts each instance of <see cref="AssetTypeHistory"/> to an instance of <see cref="AssetTypeHistoryDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<AssetTypeHistoryDTO> ToDTOs(this IEnumerable<AssetTypeHistory> entities)
        {
            if (entities == null) return null;
    
            return entities.Select(e => e.ToDTO()).ToList();
        }
    
    }
}
