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
    /// DTO Mapper for <see cref="AssetTypeAssetHistory"/> and <see cref="AssetTypeAssetHistoryDTO"/>.
    /// </summary>
    static public partial class AssetTypeAssetHistoryMapper
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="AssetTypeAssetHistoryDTO"/> converted from <see cref="AssetTypeAssetHistory"/>.</param>
        static partial void OnDTO(this AssetTypeAssetHistory entity, AssetTypeAssetHistoryDTO dto);
       
        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="AssetTypeAssetHistory"/> converted from <see cref="AssetTypeAssetHistoryDTO"/>.</param>
        static partial void OnEntity(this AssetTypeAssetHistoryDTO dto, AssetTypeAssetHistory entity);
    
    
        /// <summary>
        /// Converts this instance of <see cref="AssetTypeAssetHistoryDTO"/> to an instance of <see cref="AssetTypeAssetHistory"/>.
        /// </summary>
        /// <param name="dto"><see cref="AssetTypeAssetHistoryDTO"/> to convert.</param>
        public static AssetTypeAssetHistory ToEntity(this AssetTypeAssetHistoryDTO dto)
        {
            if (dto == null) return null;
    
            var entity = new AssetTypeAssetHistory();
                 
            entity.ID = dto.ID;     
            entity.AssetTypeID = dto.AssetTypeID;     
            entity.AssetID = dto.AssetID;     
            entity.ModifiedByUserID = dto.ModifiedByUserID;     
            entity.ModifiedDate = dto.ModifiedDate;     
            entity.AuditDate = dto.AuditDate;        
            dto.OnEntity(entity);
    
            return entity;
        }
    
        /// <summary>
        /// Converts this instance of <see cref="AssetTypeAssetHistory"/> to an instance of <see cref="AssetTypeAssetHistoryDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="AssetTypeAssetHistory"/> to convert.</param>
        public static AssetTypeAssetHistoryDTO ToDTO(this AssetTypeAssetHistory entity)
        {
            if (entity == null) return null;
    
            var dto = new AssetTypeAssetHistoryDTO();
                 
            dto.ID = entity.ID;     
            dto.AssetTypeID = entity.AssetTypeID;     
            dto.AssetID = entity.AssetID;     
            dto.ModifiedByUserID = entity.ModifiedByUserID;     
            dto.ModifiedDate = entity.ModifiedDate;     
            dto.AuditDate = entity.AuditDate;
            entity.OnDTO(dto);
    
            return dto;
        }
    
        /// <summary>
        /// Converts each instance of <see cref="AssetTypeAssetHistoryDTO"/> to an instance of <see cref="AssetTypeAssetHistory"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<AssetTypeAssetHistory> ToEntities(this IEnumerable<AssetTypeAssetHistoryDTO> dtos)
        {
            if (dtos == null) return null;
    
            return dtos.Select(e => e.ToEntity()).ToList();
        }
    
        /// <summary>
        /// Converts each instance of <see cref="AssetTypeAssetHistory"/> to an instance of <see cref="AssetTypeAssetHistoryDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<AssetTypeAssetHistoryDTO> ToDTOs(this IEnumerable<AssetTypeAssetHistory> entities)
        {
            if (entities == null) return null;
    
            return entities.Select(e => e.ToDTO()).ToList();
        }
    
    }
}