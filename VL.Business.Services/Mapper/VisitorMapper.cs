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
    /// DTO Mapper for <see cref="Visitor"/> and <see cref="VisitorEntity"/>.
    /// </summary>
    static public partial class VisitorMapper
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="VisitorEntity"/> converted from <see cref="Visitor"/>.</param>
        static partial void OnDTO(this Visitor entity, VisitorEntity dto);
       
        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="Visitor"/> converted from <see cref="VisitorEntity"/>.</param>
        static partial void OnEntity(this VisitorEntity dto, Visitor entity);
    
    
        /// <summary>
        /// Converts this instance of <see cref="VisitorEntity"/> to an instance of <see cref="Visitor"/>.
        /// </summary>
        /// <param name="dto"><see cref="VisitorEntity"/> to convert.</param>
        public static Visitor ToEntity(this VisitorEntity dto)
        {
            if (dto == null) return null;
    
            var entity = new Visitor();
                 
            entity.VisitID = dto.VisitID;     
            entity.VisitorNo = dto.VisitorNo;     
            entity.Visitor1 = dto.Visitor1;     
            entity.SecuredAreaId = dto.SecuredAreaId;     
            entity.TenantDepartmentId = dto.TenantDepartmentId;     
            entity.TypeId = dto.TypeId;        
            dto.OnEntity(entity);
    
            return entity;
        }
    
        /// <summary>
        /// Converts this instance of <see cref="Visitor"/> to an instance of <see cref="VisitorEntity"/>.
        /// </summary>
        /// <param name="entity"><see cref="Visitor"/> to convert.</param>
        public static VisitorEntity ToDTO(this Visitor entity)
        {
            if (entity == null) return null;
    
            var dto = new VisitorEntity();
                 
            dto.VisitID = entity.VisitID;     
            dto.VisitorNo = entity.VisitorNo;     
            dto.Visitor1 = entity.Visitor1;     
            dto.SecuredAreaId = entity.SecuredAreaId;     
            dto.TenantDepartmentId = entity.TenantDepartmentId;     
            dto.TypeId = entity.TypeId;
            entity.OnDTO(dto);
    
            return dto;
        }
    
        /// <summary>
        /// Converts each instance of <see cref="VisitorEntity"/> to an instance of <see cref="Visitor"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<Visitor> ToEntities(this IEnumerable<VisitorEntity> dtos)
        {
            if (dtos == null) return null;
    
            return dtos.Select(e => e.ToEntity()).ToList();
        }
    
        /// <summary>
        /// Converts each instance of <see cref="Visitor"/> to an instance of <see cref="VisitorEntity"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<VisitorEntity> ToDTOs(this IEnumerable<Visitor> entities)
        {
            if (entities == null) return null;
    
            return entities.Select(e => e.ToDTO()).ToList();
        }
    
    }
}