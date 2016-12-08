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
    /// DTO Mapper for <see cref="VisitorLogRoomID"/> and <see cref="VisitorLogRoomIDEntity"/>.
    /// </summary>
    static public partial class VisitorLogRoomIDMapper
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="VisitorLogRoomIDEntity"/> converted from <see cref="VisitorLogRoomID"/>.</param>
        static partial void OnDTO(this VisitorLogRoomID entity, VisitorLogRoomIDEntity dto);
       
        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="VisitorLogRoomID"/> converted from <see cref="VisitorLogRoomIDEntity"/>.</param>
        static partial void OnEntity(this VisitorLogRoomIDEntity dto, VisitorLogRoomID entity);
    
    
        /// <summary>
        /// Converts this instance of <see cref="VisitorLogRoomIDEntity"/> to an instance of <see cref="VisitorLogRoomID"/>.
        /// </summary>
        /// <param name="dto"><see cref="VisitorLogRoomIDEntity"/> to convert.</param>
        public static VisitorLogRoomID ToEntity(this VisitorLogRoomIDEntity dto)
        {
            if (dto == null) return null;
    
            var entity = new VisitorLogRoomID();
                 
            entity.VisitID = dto.VisitID;     
            entity.RoomID = dto.RoomID;     
            entity.OtherRoom = dto.OtherRoom;        
            dto.OnEntity(entity);
    
            return entity;
        }
    
        /// <summary>
        /// Converts this instance of <see cref="VisitorLogRoomID"/> to an instance of <see cref="VisitorLogRoomIDEntity"/>.
        /// </summary>
        /// <param name="entity"><see cref="VisitorLogRoomID"/> to convert.</param>
        public static VisitorLogRoomIDEntity ToDTO(this VisitorLogRoomID entity)
        {
            if (entity == null) return null;
    
            var dto = new VisitorLogRoomIDEntity();
                 
            dto.VisitID = entity.VisitID;     
            dto.RoomID = entity.RoomID;     
            dto.OtherRoom = entity.OtherRoom;
            entity.OnDTO(dto);
    
            return dto;
        }
    
        /// <summary>
        /// Converts each instance of <see cref="VisitorLogRoomIDEntity"/> to an instance of <see cref="VisitorLogRoomID"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<VisitorLogRoomID> ToEntities(this IEnumerable<VisitorLogRoomIDEntity> dtos)
        {
            if (dtos == null) return null;
    
            return dtos.Select(e => e.ToEntity()).ToList();
        }
    
        /// <summary>
        /// Converts each instance of <see cref="VisitorLogRoomID"/> to an instance of <see cref="VisitorLogRoomIDEntity"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<VisitorLogRoomIDEntity> ToDTOs(this IEnumerable<VisitorLogRoomID> entities)
        {
            if (entities == null) return null;
    
            return entities.Select(e => e.ToDTO()).ToList();
        }
    
    }
}
