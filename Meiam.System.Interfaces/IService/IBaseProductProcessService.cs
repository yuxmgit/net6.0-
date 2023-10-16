//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
//     author MEIAM
// </auto-generated>
//------------------------------------------------------------------------------
using Meiam.System.Model;
using Meiam.System.Model.Dto;
using Meiam.System.Model.View;
using System.Collections.Generic;
using System.Threading.Tasks;
using SqlSugar;
using System.Linq;
using System;

namespace Meiam.System.Interfaces
{
    public interface IBaseProductProcessService : IBaseService<Base_ProductProcess>
    {

        #region CustomInterface 
        /// <summary>
        /// 查询工序（分页）
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        PagedInfo<ProductProcessVM> QueryProcessPages(ProductProcessQueryDto parm);

        /// <summary>
        /// 根据ID查询工序
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ProductProcessVM GetProcess(string id);

        /// <summary>
        /// 查询所有工序
        /// </summary>
        /// <returns></returns>
        List<ProductProcessVM> GetAllProcess(bool? enable = null);

        /// <summary>
        /// 查询同车间下是否存在相同工序编码
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="processNo"></param>
        /// <param name="workshopId"></param>
        /// <returns></returns>
        bool Any(string Id, string processNo, string workshopId);
        #endregion

    }
}