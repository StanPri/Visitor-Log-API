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
    /// DTO Mapper for <see cref="Station"/> and <see cref="StationDTO"/>.
    /// </summary>
    static public partial class StationMapper
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="StationDTO"/> converted from <see cref="Station"/>.</param>
        static partial void OnDTO(this Station entity, StationDTO dto);
       
        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="Station"/> converted from <see cref="StationDTO"/>.</param>
        static partial void OnEntity(this StationDTO dto, Station entity);
    
    
        /// <summary>
        /// Converts this instance of <see cref="StationDTO"/> to an instance of <see cref="Station"/>.
        /// </summary>
        /// <param name="dto"><see cref="StationDTO"/> to convert.</param>
        public static Station ToEntity(this StationDTO dto)
        {
            if (dto == null) return null;
    
            var entity = new Station();
                 
            entity.ID = dto.ID;     
            entity.Code = dto.Code;     
            entity.Name = dto.Name;     
            entity.CreatedByUserID = dto.CreatedByUserID;     
            entity.CreatedDate = dto.CreatedDate;     
            entity.ModifiedByUserID = dto.ModifiedByUserID;     
            entity.ModifiedDate = dto.ModifiedDate;     
            entity.IsActive = dto.IsActive;        
            dto.OnEntity(entity);
    
            return entity;
        }
    
        /// <summary>
        /// Converts this instance of <see cref="Station"/> to an instance of <see cref="StationDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="Station"/> to convert.</param>
        public static StationDTO ToDTO(this Station entity)
        {
            if (entity == null) return null;
    
            var dto = new StationDTO();
                 
            dto.ID = entity.ID;     
            dto.Code = entity.Code;     
            dto.Name = entity.Name;     
            dto.CreatedByUserID = entity.CreatedByUserID;     
            dto.CreatedDate = entity.CreatedDate;     
            dto.ModifiedByUserID = entity.ModifiedByUserID;     
            dto.ModifiedDate = entity.ModifiedDate;     
            dto.IsActive = entity.IsActive;
            entity.OnDTO(dto);
    
            return dto;
        }
    
        /// <summary>
        /// Converts each instance of <see cref="StationDTO"/> to an instance of <see cref="Station"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<Station> ToEntities(this IEnumerable<StationDTO> dtos)
        {
            if (dtos == null) return null;
    
            return dtos.Select(e => e.ToEntity()).ToList();
        }
    
        /// <summary>
        /// Converts each instance of <see cref="Station"/> to an instance of <see cref="StationDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<StationDTO> ToDTOs(this IEnumerable<Station> entities)
        {
            if (entities == null) return null;
    
            return entities.Select(e => e.ToDTO()).ToList();
        }
    
    }
}
