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
    /// DTO Mapper for <see cref="Log"/> and <see cref="LogDTO"/>.
    /// </summary>
    static public partial class LogMapper
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="LogDTO"/> converted from <see cref="Log"/>.</param>
        static partial void OnDTO(this Log entity, LogDTO dto);
       
        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="Log"/> converted from <see cref="LogDTO"/>.</param>
        static partial void OnEntity(this LogDTO dto, Log entity);
    
    
        /// <summary>
        /// Converts this instance of <see cref="LogDTO"/> to an instance of <see cref="Log"/>.
        /// </summary>
        /// <param name="dto"><see cref="LogDTO"/> to convert.</param>
        public static Log ToEntity(this LogDTO dto)
        {
            if (dto == null) return null;
    
            var entity = new Log();
                 
            entity.ID = dto.ID;     
            entity.StartDate = dto.StartDate;     
            entity.EndDate = dto.EndDate;     
            entity.Reason = dto.Reason;     
            entity.SpecialInstructions = dto.SpecialInstructions;     
            entity.CreatedByUserID = dto.CreatedByUserID;     
            entity.CreatedDate = dto.CreatedDate;     
            entity.ModifiedByUserID = dto.ModifiedByUserID;     
            entity.ModifiedDate = dto.ModifiedDate;        
            dto.OnEntity(entity);
    
            return entity;
        }
    
        /// <summary>
        /// Converts this instance of <see cref="Log"/> to an instance of <see cref="LogDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="Log"/> to convert.</param>
        public static LogDTO ToDTO(this Log entity)
        {
            if (entity == null) return null;
    
            var dto = new LogDTO();
                 
            dto.ID = entity.ID;     
            dto.StartDate = entity.StartDate;     
            dto.EndDate = entity.EndDate;     
            dto.Reason = entity.Reason;     
            dto.SpecialInstructions = entity.SpecialInstructions;     
            dto.CreatedByUserID = entity.CreatedByUserID;     
            dto.CreatedDate = entity.CreatedDate;     
            dto.ModifiedByUserID = entity.ModifiedByUserID;     
            dto.ModifiedDate = entity.ModifiedDate;
            entity.OnDTO(dto);
    
            return dto;
        }
    
        /// <summary>
        /// Converts each instance of <see cref="LogDTO"/> to an instance of <see cref="Log"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<Log> ToEntities(this IEnumerable<LogDTO> dtos)
        {
            if (dtos == null) return null;
    
            return dtos.Select(e => e.ToEntity()).ToList();
        }
    
        /// <summary>
        /// Converts each instance of <see cref="Log"/> to an instance of <see cref="LogDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<LogDTO> ToDTOs(this IEnumerable<Log> entities)
        {
            if (entities == null) return null;
    
            return entities.Select(e => e.ToDTO()).ToList();
        }
    
    }
}
