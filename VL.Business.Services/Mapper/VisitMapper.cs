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
    /// DTO Mapper for <see cref="Visit"/> and <see cref="VisitDTO"/>.
    /// </summary>
    static public partial class VisitMapper
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="VisitDTO"/> converted from <see cref="Visit"/>.</param>
        static partial void OnDTO(this Visit entity, VisitDTO dto);
       
        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="Visit"/> converted from <see cref="VisitDTO"/>.</param>
        static partial void OnEntity(this VisitDTO dto, Visit entity);
    
    
        /// <summary>
        /// Converts this instance of <see cref="VisitDTO"/> to an instance of <see cref="Visit"/>.
        /// </summary>
        /// <param name="dto"><see cref="VisitDTO"/> to convert.</param>
        public static Visit ToEntity(this VisitDTO dto)
        {
            if (dto == null) return null;
    
            var entity = new Visit();
                 
            entity.ID = dto.ID;     
            entity.ScheduledCheckInTime = dto.ScheduledCheckInTime;     
            entity.ScheduledCheckOutTime = dto.ScheduledCheckOutTime;     
            entity.ActualCheckInTime = dto.ActualCheckInTime;     
            entity.ActualCheckOutTime = dto.ActualCheckOutTime;     
            entity.CreatedByUserID = dto.CreatedByUserID;     
            entity.CreatedDate = dto.CreatedDate;     
            entity.ModifiedByUserID = dto.ModifiedByUserID;     
            entity.ModifiedDate = dto.ModifiedDate;        
            dto.OnEntity(entity);
    
            return entity;
        }
    
        /// <summary>
        /// Converts this instance of <see cref="Visit"/> to an instance of <see cref="VisitDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="Visit"/> to convert.</param>
        public static VisitDTO ToDTO(this Visit entity)
        {
            if (entity == null) return null;
    
            var dto = new VisitDTO();
                 
            dto.ID = entity.ID;     
            dto.ScheduledCheckInTime = entity.ScheduledCheckInTime;     
            dto.ScheduledCheckOutTime = entity.ScheduledCheckOutTime;     
            dto.ActualCheckInTime = entity.ActualCheckInTime;     
            dto.ActualCheckOutTime = entity.ActualCheckOutTime;     
            dto.CreatedByUserID = entity.CreatedByUserID;     
            dto.CreatedDate = entity.CreatedDate;     
            dto.ModifiedByUserID = entity.ModifiedByUserID;     
            dto.ModifiedDate = entity.ModifiedDate;
            entity.OnDTO(dto);
    
            return dto;
        }
    
        /// <summary>
        /// Converts each instance of <see cref="VisitDTO"/> to an instance of <see cref="Visit"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<Visit> ToEntities(this IEnumerable<VisitDTO> dtos)
        {
            if (dtos == null) return null;
    
            return dtos.Select(e => e.ToEntity()).ToList();
        }
    
        /// <summary>
        /// Converts each instance of <see cref="Visit"/> to an instance of <see cref="VisitDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<VisitDTO> ToDTOs(this IEnumerable<Visit> entities)
        {
            if (entities == null) return null;
    
            return entities.Select(e => e.ToDTO()).ToList();
        }
    
    }
}