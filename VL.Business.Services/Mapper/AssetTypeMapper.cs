//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// 
//  Author: Johnny Vu
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
    /// DTO Mapper for <see cref="AssetType"/> and <see cref="AssetTypeDTO"/>.
    /// </summary>
    static public partial class AssetTypeMapper
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="AssetTypeDTO"/> converted from <see cref="AssetType"/>.</param>
        static partial void OnDTO(this AssetType entity, AssetTypeDTO dto);
       
        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="AssetType"/> converted from <see cref="AssetTypeDTO"/>.</param>
        static partial void OnEntity(this AssetTypeDTO dto, AssetType entity);
    
    
        /// <summary>
        /// Converts this instance of <see cref="AssetTypeDTO"/> to an instance of <see cref="AssetType"/>.
        /// </summary>
        /// <param name="dto"><see cref="AssetTypeDTO"/> to convert.</param>
        public static AssetType ToEntity(this AssetTypeDTO dto)
        {
            if (dto == null) return null;
    
            var entity = new AssetType();
                 
            entity.ID = dto.ID;     
            entity.Code = dto.Code;     
            entity.Name = dto.Name;     
            entity.CreatedByUserID = dto.CreatedByUserID;     
            entity.CreatedDate = dto.CreatedDate;     
            entity.ModifiedByUserID = dto.ModifiedByUserID;     
            entity.ModifiedDate = dto.ModifiedDate;        
            dto.OnEntity(entity);
    
            return entity;
        }
    
        /// <summary>
        /// Converts this instance of <see cref="AssetType"/> to an instance of <see cref="AssetTypeDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="AssetType"/> to convert.</param>
        public static AssetTypeDTO ToDTO(this AssetType entity)
        {
            if (entity == null) return null;
    
            var dto = new AssetTypeDTO();
                 
            dto.ID = entity.ID;     
            dto.Code = entity.Code;     
            dto.Name = entity.Name;     
            dto.CreatedByUserID = entity.CreatedByUserID;     
            dto.CreatedDate = entity.CreatedDate;     
            dto.ModifiedByUserID = entity.ModifiedByUserID;     
            dto.ModifiedDate = entity.ModifiedDate;
            entity.OnDTO(dto);
    
            return dto;
        }
    
        /// <summary>
        /// Converts each instance of <see cref="AssetTypeDTO"/> to an instance of <see cref="AssetType"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<AssetType> ToEntities(this IEnumerable<AssetTypeDTO> dtos)
        {
            if (dtos == null) return null;
    
            return dtos.Select(e => e.ToEntity()).ToList();
        }
    
        /// <summary>
        /// Converts each instance of <see cref="AssetType"/> to an instance of <see cref="AssetTypeDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<AssetTypeDTO> ToDTOs(this IEnumerable<AssetType> entities)
        {
            if (entities == null) return null;
    
            return entities.Select(e => e.ToDTO()).ToList();
        }
    
    }
}
