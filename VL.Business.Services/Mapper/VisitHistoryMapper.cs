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
    /// DTO Mapper for <see cref="VisitHistory"/> and <see cref="VisitHistoryDTO"/>.
    /// </summary>
    static public partial class VisitHistoryMapper
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="VisitHistoryDTO"/> converted from <see cref="VisitHistory"/>.</param>
        static partial void OnDTO(this VisitHistory entity, VisitHistoryDTO dto);
       
        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="VisitHistory"/> converted from <see cref="VisitHistoryDTO"/>.</param>
        static partial void OnEntity(this VisitHistoryDTO dto, VisitHistory entity);
    
    
        /// <summary>
        /// Converts this instance of <see cref="VisitHistoryDTO"/> to an instance of <see cref="VisitHistory"/>.
        /// </summary>
        /// <param name="dto"><see cref="VisitHistoryDTO"/> to convert.</param>
        public static VisitHistory ToEntity(this VisitHistoryDTO dto)
        {
            if (dto == null) return null;
    
            var entity = new VisitHistory();
                 
            entity.ID = dto.ID;     
            entity.VisitID = dto.VisitID;     
            entity.ScheduledCheckInTime = dto.ScheduledCheckInTime;     
            entity.ScheduledCheckOutTime = dto.ScheduledCheckOutTime;     
            entity.ActualCheckInTime = dto.ActualCheckInTime;     
            entity.ActualCheckOutTime = dto.ActualCheckOutTime;     
            entity.ModifiedByUserID = dto.ModifiedByUserID;     
            entity.ModifiedDate = dto.ModifiedDate;     
            entity.AuditDate = dto.AuditDate;        
            dto.OnEntity(entity);
    
            return entity;
        }
    
        /// <summary>
        /// Converts this instance of <see cref="VisitHistory"/> to an instance of <see cref="VisitHistoryDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="VisitHistory"/> to convert.</param>
        public static VisitHistoryDTO ToDTO(this VisitHistory entity)
        {
            if (entity == null) return null;
    
            var dto = new VisitHistoryDTO();
                 
            dto.ID = entity.ID;     
            dto.VisitID = entity.VisitID;     
            dto.ScheduledCheckInTime = entity.ScheduledCheckInTime;     
            dto.ScheduledCheckOutTime = entity.ScheduledCheckOutTime;     
            dto.ActualCheckInTime = entity.ActualCheckInTime;     
            dto.ActualCheckOutTime = entity.ActualCheckOutTime;     
            dto.ModifiedByUserID = entity.ModifiedByUserID;     
            dto.ModifiedDate = entity.ModifiedDate;     
            dto.AuditDate = entity.AuditDate;
            entity.OnDTO(dto);
    
            return dto;
        }
    
        /// <summary>
        /// Converts each instance of <see cref="VisitHistoryDTO"/> to an instance of <see cref="VisitHistory"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<VisitHistory> ToEntities(this IEnumerable<VisitHistoryDTO> dtos)
        {
            if (dtos == null) return null;
    
            return dtos.Select(e => e.ToEntity()).ToList();
        }
    
        /// <summary>
        /// Converts each instance of <see cref="VisitHistory"/> to an instance of <see cref="VisitHistoryDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<VisitHistoryDTO> ToDTOs(this IEnumerable<VisitHistory> entities)
        {
            if (entities == null) return null;
    
            return entities.Select(e => e.ToDTO()).ToList();
        }
    
    }
}
