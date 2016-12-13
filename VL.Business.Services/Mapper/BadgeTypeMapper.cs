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
    /// DTO Mapper for <see cref="BadgeType"/> and <see cref="BadgeTypeDTO"/>.
    /// </summary>
    static public partial class BadgeTypeMapper
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="BadgeTypeDTO"/> converted from <see cref="BadgeType"/>.</param>
        static partial void OnDTO(this BadgeType entity, BadgeTypeDTO dto);
       
        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="BadgeType"/> converted from <see cref="BadgeTypeDTO"/>.</param>
        static partial void OnEntity(this BadgeTypeDTO dto, BadgeType entity);
    
    
        /// <summary>
        /// Converts this instance of <see cref="BadgeTypeDTO"/> to an instance of <see cref="BadgeType"/>.
        /// </summary>
        /// <param name="dto"><see cref="BadgeTypeDTO"/> to convert.</param>
        public static BadgeType ToEntity(this BadgeTypeDTO dto)
        {
            if (dto == null) return null;
    
            var entity = new BadgeType();
                 
            entity.ID = dto.ID;     
            entity.Code = dto.Code;     
            entity.Name = dto.Name;     
            entity.CreatedByUserID = dto.CreatedByUserID;     
            entity.CreatedDate = dto.CreatedDate;     
            entity.ModifiedByUserID = dto.ModifiedByUserID;     
            entity.ModifedDate = dto.ModifedDate;        
            dto.OnEntity(entity);
    
            return entity;
        }
    
        /// <summary>
        /// Converts this instance of <see cref="BadgeType"/> to an instance of <see cref="BadgeTypeDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="BadgeType"/> to convert.</param>
        public static BadgeTypeDTO ToDTO(this BadgeType entity)
        {
            if (entity == null) return null;
    
            var dto = new BadgeTypeDTO();
                 
            dto.ID = entity.ID;     
            dto.Code = entity.Code;     
            dto.Name = entity.Name;     
            dto.CreatedByUserID = entity.CreatedByUserID;     
            dto.CreatedDate = entity.CreatedDate;     
            dto.ModifiedByUserID = entity.ModifiedByUserID;     
            dto.ModifedDate = entity.ModifedDate;
            entity.OnDTO(dto);
    
            return dto;
        }
    
        /// <summary>
        /// Converts each instance of <see cref="BadgeTypeDTO"/> to an instance of <see cref="BadgeType"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<BadgeType> ToEntities(this IEnumerable<BadgeTypeDTO> dtos)
        {
            if (dtos == null) return null;
    
            return dtos.Select(e => e.ToEntity()).ToList();
        }
    
        /// <summary>
        /// Converts each instance of <see cref="BadgeType"/> to an instance of <see cref="BadgeTypeDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<BadgeTypeDTO> ToDTOs(this IEnumerable<BadgeType> entities)
        {
            if (entities == null) return null;
    
            return entities.Select(e => e.ToDTO()).ToList();
        }
    
    }
}
