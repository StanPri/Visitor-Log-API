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
    /// DTO Mapper for <see cref="AccessArea"/> and <see cref="AccessAreaEntity"/>.
    /// </summary>
    static public partial class AccessAreaMapper
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="AccessAreaEntity"/> converted from <see cref="AccessArea"/>.</param>
        static partial void OnDTO(this AccessArea entity, AccessAreaEntity dto);
       
        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="AccessArea"/> converted from <see cref="AccessAreaEntity"/>.</param>
        static partial void OnEntity(this AccessAreaEntity dto, AccessArea entity);
    
    
        /// <summary>
        /// Converts this instance of <see cref="AccessAreaEntity"/> to an instance of <see cref="AccessArea"/>.
        /// </summary>
        /// <param name="dto"><see cref="AccessAreaEntity"/> to convert.</param>
        public static AccessArea ToEntity(this AccessAreaEntity dto)
        {
            if (dto == null) return null;
    
            var entity = new AccessArea();
                 
            entity.AccessID = dto.AccessID;     
            entity.CampusID = dto.CampusID;     
            entity.Access = dto.Access;     
            entity.Active = dto.Active;        
            dto.OnEntity(entity);
    
            return entity;
        }
    
        /// <summary>
        /// Converts this instance of <see cref="AccessArea"/> to an instance of <see cref="AccessAreaEntity"/>.
        /// </summary>
        /// <param name="entity"><see cref="AccessArea"/> to convert.</param>
        public static AccessAreaEntity ToDTO(this AccessArea entity)
        {
            if (entity == null) return null;
    
            var dto = new AccessAreaEntity();
                 
            dto.AccessID = entity.AccessID;     
            dto.CampusID = entity.CampusID;     
            dto.Access = entity.Access;     
            dto.Active = entity.Active;
            entity.OnDTO(dto);
    
            return dto;
        }
    
        /// <summary>
        /// Converts each instance of <see cref="AccessAreaEntity"/> to an instance of <see cref="AccessArea"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<AccessArea> ToEntities(this IEnumerable<AccessAreaEntity> dtos)
        {
            if (dtos == null) return null;
    
            return dtos.Select(e => e.ToEntity()).ToList();
        }
    
        /// <summary>
        /// Converts each instance of <see cref="AccessArea"/> to an instance of <see cref="AccessAreaEntity"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<AccessAreaEntity> ToDTOs(this IEnumerable<AccessArea> entities)
        {
            if (entities == null) return null;
    
            return entities.Select(e => e.ToDTO()).ToList();
        }
    
    }
}
