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
    /// DTO Mapper for <see cref="Campus"/> and <see cref="CampusDTO"/>.
    /// </summary>
    static public partial class CampusMapper
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="CampusDTO"/> converted from <see cref="Campus"/>.</param>
        static partial void OnDTO(this Campus entity, CampusDTO dto);
       
        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="Campus"/> converted from <see cref="CampusDTO"/>.</param>
        static partial void OnEntity(this CampusDTO dto, Campus entity);
    
    
        /// <summary>
        /// Converts this instance of <see cref="CampusDTO"/> to an instance of <see cref="Campus"/>.
        /// </summary>
        /// <param name="dto"><see cref="CampusDTO"/> to convert.</param>
        public static Campus ToEntity(this CampusDTO dto)
        {
            if (dto == null) return null;
    
            var entity = new Campus();
                 
            entity.ID = dto.ID;     
            entity.Name = dto.Name;     
            entity.Address = dto.Address;     
            entity.Address2 = dto.Address2;     
            entity.City = dto.City;     
            entity.ZipCode = dto.ZipCode;     
            entity.IsActive = dto.IsActive;     
            entity.CreatedByUserID = dto.CreatedByUserID;     
            entity.CreatedDate = dto.CreatedDate;     
            entity.ModifiedByUserID = dto.ModifiedByUserID;     
            entity.ModifiedDate = dto.ModifiedDate;        
            dto.OnEntity(entity);
    
            return entity;
        }
    
        /// <summary>
        /// Converts this instance of <see cref="Campus"/> to an instance of <see cref="CampusDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="Campus"/> to convert.</param>
        public static CampusDTO ToDTO(this Campus entity)
        {
            if (entity == null) return null;
    
            var dto = new CampusDTO();
                 
            dto.ID = entity.ID;     
            dto.Name = entity.Name;     
            dto.Address = entity.Address;     
            dto.Address2 = entity.Address2;     
            dto.City = entity.City;     
            dto.ZipCode = entity.ZipCode;     
            dto.IsActive = entity.IsActive;     
            dto.CreatedByUserID = entity.CreatedByUserID;     
            dto.CreatedDate = entity.CreatedDate;     
            dto.ModifiedByUserID = entity.ModifiedByUserID;     
            dto.ModifiedDate = entity.ModifiedDate;
            entity.OnDTO(dto);
    
            return dto;
        }
    
        /// <summary>
        /// Converts each instance of <see cref="CampusDTO"/> to an instance of <see cref="Campus"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<Campus> ToEntities(this IEnumerable<CampusDTO> dtos)
        {
            if (dtos == null) return null;
    
            return dtos.Select(e => e.ToEntity()).ToList();
        }
    
        /// <summary>
        /// Converts each instance of <see cref="Campus"/> to an instance of <see cref="CampusDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<CampusDTO> ToDTOs(this IEnumerable<Campus> entities)
        {
            if (entities == null) return null;
    
            return entities.Select(e => e.ToDTO()).ToList();
        }
    
    }
}
