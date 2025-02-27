﻿using System;
using System.Collections.Generic;
using System.Text; 

namespace ReZero.SuperAPI
{
    internal partial class InterfaceListInitializerProvider
    {
        /// <summary>
        /// 数据库管理
        /// </summary> 
        [ChineseTextAttribute("数据库管理")]
        [EnglishTextAttribute("Database management")]
        public const long DbManId = 1;


        /// <summary>
        /// 获取数据库管理所有
        /// </summary> 
        [ChineseTextAttribute("获取数据库管理所有")]
        [EnglishTextAttribute("Database all list")]
        public const long GetDbAllId = 23;


        /// <summary>
        /// 删除数据库
        /// </summary> 
        [ChineseTextAttribute("删除数据库")]
        [EnglishTextAttribute("Daelete Database")]
        public const long DelDbManId = 11;

        /// <summary>
        /// 添加数据库
        /// </summary> 
        [ChineseTextAttribute("添加数据库")]
        [EnglishTextAttribute("Add Database")]
        public const long AddDbManId = 12;

        /// <summary>
        /// 修改库管理
        /// </summary> 
        [ChineseTextAttribute("添加数据库")]
        [EnglishTextAttribute("Edit Database")]
        public const long EditDbManId = 13;

        /// <summary>
        /// 获取数据库根据ID
        /// </summary> 
        [ChineseTextAttribute("获取数据库根据ID")]
        [EnglishTextAttribute("Get database by id")]
        public const long GetDbManIdById = 14;

        /// <summary>
        /// 测试数据库
        /// </summary> 
        [ChineseTextAttribute("测试数据库")]
        [EnglishTextAttribute("Test database")]
        public const long TestDatabaseId=16;

        /// <summary>
        /// 创建数据库
        /// </summary> 
        [ChineseTextAttribute("创建数据库")]
        [EnglishTextAttribute("Create database")]
        public const long CreateDatabaseId = 17;

        /// <summary>
        /// 内部接口
        /// </summary> 
        [ChineseTextAttribute("接口列表")]
        [EnglishTextAttribute("Internal interface list")]
        public const long IntIntListId = 2;
        /// <summary>
        /// 接口分类
        /// </summary> 
        [ChineseTextAttribute("动态分类列表")]
        [EnglishTextAttribute("Dynamic category list")]
        public const long IntCatePageListId = 3;

        /// <summary>
        /// 接口详情
        /// </summary>
        [ChineseTextAttribute("接口详情")]
        [EnglishTextAttribute("Interface Detail")]
        public const long IntDetId = 4;



        ///// <summary>
        ///// 动态接口[测试01]
        ///// </summary>
        //[ChineseTextAttribute("测试动态接口01")]
        //[EnglishTextAttribute("Test API 01")]
        //public const long TestId = 175179646053135000;


        /// <summary>
        /// 接口分类树
        /// </summary> 
        [ChineseTextAttribute("接口分类树")]
        [EnglishTextAttribute("Interface category tree")]
        public const long IntCateTreeId = 6;


        /// <summary>
        /// 添加动态接口分类
        /// </summary> 
        [ChineseTextAttribute("添加动态接口分类")]
        [EnglishTextAttribute("Add dynamic category")]
        public const long AddCateTreeId = 7;

        [ChineseTextAttribute("修改动态接口分类")]
        [EnglishTextAttribute("Update dynamic category")]
        public const long UpdateCateTreeId = 8;

        [ChineseTextAttribute("删除动态接口分类")]
        [EnglishTextAttribute("Delete dynamic category")]
        public const long DeleteCateTreeId = 9;


        [ChineseTextAttribute("根据主键查询接口分类")]
        [EnglishTextAttribute("Get category by id")]
        public const long GetCateTreeById = 10;

        [ChineseTextAttribute("下拉列表：获取数据库类型")]
        [EnglishTextAttribute("Get database type list")]

        public const long GetDbTypeListId = 15;

        [ChineseTextAttribute("下拉列表：获取c#类型")]
        [EnglishTextAttribute("Get c# type")]

        public const long GetNativeTypeId = 24;



        [ChineseTextAttribute("获取实体列表")]
        [EnglishTextAttribute("Get entity list")]

        public const long GetEntityInfoListId = 18;


        [ChineseTextAttribute("获取实体根据主键")]
        [EnglishTextAttribute("Get entity by id")]

        public const long GetEntityInfoById_Id = 19;

        [ChineseTextAttribute("删除实体")]
        [EnglishTextAttribute("Delete entity")]

        public const long DeleteEntityInfoById = 20;


        [ChineseTextAttribute("添加实体")]
        [EnglishTextAttribute("Add entity")]

        public const long AddEntityInfoId = 21;

        [ChineseTextAttribute("更新实体")]
        [EnglishTextAttribute("Update entity")]

        public const long UpdateEntityInfoId = 22;


        [ChineseTextAttribute("获取属性根据实体ID")]
        [EnglishTextAttribute("Get entity columns")]
        public const long GetEntityColumnsByEntityId_Id = 25;

        [ChineseTextAttribute("更新实体属性")]
        [EnglishTextAttribute("Update entity columns")]
        public const long UpdateEntityColumnInfosId= 26;

        [ChineseTextAttribute("表结构对比")]
        [EnglishTextAttribute("Compare database dtructure")]
        public const long CompareDatabaseStructureId = 27;


        [ChineseTextAttribute("创建表")]
        [EnglishTextAttribute("Create table")]
        public const long CreateTablesId = 28;

         
        [ChineseTextAttribute("获取导入的表")]
        [EnglishTextAttribute("Get import tables ")]
        public const long GetImportTablesId = 29;


        [ChineseTextAttribute("导入实体")]
        [EnglishTextAttribute("Import entities")]
        public const long ImportEntitiesId = 30;

         
        [ChineseTextAttribute("接口列表分页")]
        [EnglishTextAttribute("dynamic interface page list")]
        public const long DynamicIntPageListId = 31;


        [ChineseTextAttribute("删除动态接口")]
        [EnglishTextAttribute("Delete dynamic interface")]
        public const long DeleteDynamicIntId = 32;

         
        [ChineseTextAttribute("下拉列表：动态分类数据源")]
        [EnglishTextAttribute("Dynamic category datasource")]
        public const long IntCateListId = 33;


        [ChineseTextAttribute("下拉列表：动态分类中的分组集合")]
        [EnglishTextAttribute("Dynamic group name datasource")]
        public const long IntCateGroupNameListId = 34;


        [ChineseTextAttribute("下拉列表：获接口操作方式集合")]
        [EnglishTextAttribute("Get interface action list ")]
        public const long GetActionTypeId = 35;

        [ChineseTextAttribute("获取所有表")]
        [EnglishTextAttribute("Get all tables ")]
        public const long GetAllTablesId = 36;


        [ChineseTextAttribute("保存接口")]
        [EnglishTextAttribute("Save interface")]
        public const long SaveInterfaceListId = 37;

        private static ZeroInterfaceList GetNewItem(Action<ZeroInterfaceList> action)
        {
            var result = new ZeroInterfaceList()
            {
                IsInitialized = true,
                DataModel = new DataModel()
            };
            action(result);
            return result;
        }

        private static string GetUrl(ZeroInterfaceList zeroInterface, string actionName)
        {
            return $"/{NamingConventionsConst.ApiReZeroRoute}/{zeroInterface.InterfaceCategoryId}/{actionName}";
        }
    }
}
