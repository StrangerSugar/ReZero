﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReZero.SuperAPI
{
    internal partial class InterfaceListInitializerProvider
    {


        private void AddInit_DatabaseInfo()
        {
            GetDatabaseInfoAllList();

            GetDatabaseInfoList();

            DeleteDatabaseInfo();

            AddDatabaseInfo();

            UpdateDatabaseInfo();

            GetDatabaseInfoById();

            TestDatabaseInfo();

            CreateDatabaseInfo();
        }

        private void CreateDatabaseInfo()
        {
            //创建数据库
            ZeroInterfaceList data8 = GetNewItem(it =>
            {
                it.HttpMethod = HttpRequestMethod.GET.ToString();
                it.Id = CreateDatabaseId;
                it.GroupName = nameof(ZeroDatabaseInfo);
                it.InterfaceCategoryId = InterfaceCategoryInitializerProvider.Id100003;
                it.Name = TextHandler.GetInterfaceListText(CreateDatabaseId);
                it.Url = GetUrl(it, "CreateDatabaseInfo"); 
                it.DataModel = new DataModel()
                {
                    TableId = EntityInfoInitializerProvider.Id_ZeroDatabaseInfo,
                    ActionType = ActionType.DllCreateDb, 
                    DefaultParameters = new List<DataModelDefaultParameter>() {
                             new DataModelDefaultParameter() { Name = "Connection",   FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(string).Name,Value=0, Description = TextHandler.GetCommonText("连接字符串", "Connection string") },
                             new DataModelDefaultParameter() { Name = "DbType",   FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(string).Name,Value=0, Description = TextHandler.GetCommonText("库类型", "DbType") }
                         }
                };
            });
            zeroInterfaceList.Add(data8);
        }

        private void TestDatabaseInfo()
        {

            //测试数据库
            ZeroInterfaceList data7 = GetNewItem(it =>
            {
                it.HttpMethod = HttpRequestMethod.GET.ToString();
                it.Id = TestDatabaseId;
                it.GroupName = nameof(ZeroDatabaseInfo);
                it.InterfaceCategoryId = InterfaceCategoryInitializerProvider.Id100003;
                it.Name = TextHandler.GetInterfaceListText(TestDatabaseId);
                it.Url = GetUrl(it, "TestDatabaseInfo");
                it.DataModel = new DataModel()
                {
                    MyMethodInfo = new MyMethodInfo()
                    {
                        MethodClassFullName = typeof(MethodApi).FullName,
                        MethodArgsCount = 1,
                        MethodName = nameof(MethodApi.TestDb)
                    },
                    TableId = EntityInfoInitializerProvider.Id_ZeroDatabaseInfo,
                    ActionType = ActionType.MyMethod,
                    DefaultParameters = new List<DataModelDefaultParameter>() {
                             new DataModelDefaultParameter() { Name = nameof(ZeroDatabaseInfo.Id),   FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(long).Name,Value=0, Description = TextHandler.GetCommonText("主键", "Id") }
                         }
                };
            });
            zeroInterfaceList.Add(data7);
        }

        private void GetDatabaseInfoById()
        {
            //获取数据库根据主键获取详情
            ZeroInterfaceList data6 = GetNewItem(it =>
            {
                it.HttpMethod = HttpRequestMethod.GET.ToString();
                it.Id = GetDbManIdById;
                it.GroupName = nameof(ZeroDatabaseInfo);
                it.InterfaceCategoryId = InterfaceCategoryInitializerProvider.Id100003;
                it.Name = TextHandler.GetInterfaceListText(GetCateTreeById);
                it.Url = GetUrl(it, "GetDatabaseInfoById");
                it.DataModel = new DataModel()
                {
                    TableId = EntityInfoInitializerProvider.Id_ZeroDatabaseInfo,
                    ActionType = ActionType.QueryByPrimaryKey,
                    DefaultParameters = new List<DataModelDefaultParameter>() {
                             new DataModelDefaultParameter() { Name = nameof(ZeroDatabaseInfo.Id),   FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(long).Name,Value=0, Description = TextHandler.GetCommonText("主键", "Id") }
                         }
                };
            });
            zeroInterfaceList.Add(data6);
        }

        private void UpdateDatabaseInfo()
        {
            ZeroInterfaceList data5 = GetNewItem(it =>
            {
                it.HttpMethod = HttpRequestMethod.POST.ToString();
                it.Id = EditDbManId;
                it.GroupName = nameof(ZeroDatabaseInfo);
                it.InterfaceCategoryId = InterfaceCategoryInitializerProvider.Id100003;
                it.Name = TextHandler.GetInterfaceListText(UpdateCateTreeId);
                it.Url = GetUrl(it, "UpdateDatabaseInfo");
                it.DataModel = new DataModel()
                {
                    TableId = EntityInfoInitializerProvider.Id_ZeroDatabaseInfo,
                    ActionType = ActionType.UpdateObject,
                    DefaultParameters = new List<DataModelDefaultParameter>()
                    {
                        new DataModelDefaultParameter() { Name=nameof(ZeroDatabaseInfo.Id),ValueType = typeof(long).Name },
                        new DataModelDefaultParameter() {
                             Name=nameof(ZeroDatabaseInfo.Name) ,
                             ParameterValidate=
                             new ParameterValidate()
                             {
                                IsRequired=true
                             } ,
                             ValueType = typeof(string).Name },
                        new DataModelDefaultParameter() {
                            Name=nameof(ZeroDatabaseInfo.DbType) ,ParameterValidate=
                            new ParameterValidate()
                            {
                                IsRequired=true
                            } ,
                            ValueType = typeof(string).Name
                        },
                        new DataModelDefaultParameter()
                        {
                            Name=nameof(ZeroDatabaseInfo.Connection),
                            ParameterValidate=
                            new ParameterValidate()
                            {
                                IsRequired=true
                            } ,ValueType = typeof(string).Name
                        }
                    }
                };
            });
            zeroInterfaceList.Add(data5);
        }

        private void AddDatabaseInfo()
        {
            ZeroInterfaceList data4 = GetNewItem(it =>
            {
                it.HttpMethod = HttpRequestMethod.POST.ToString();
                it.Id = AddDbManId;
                it.GroupName = nameof(ZeroDatabaseInfo);
                it.InterfaceCategoryId = InterfaceCategoryInitializerProvider.Id100003;
                it.Name = TextHandler.GetInterfaceListText(AddCateTreeId);
                it.Url = GetUrl(it, "AddDatabaseInfo");
                it.DataModel = new DataModel()
                {
                    TableId = EntityInfoInitializerProvider.Id_ZeroDatabaseInfo,
                    ActionType = ActionType.InsertObject,
                    DefaultParameters = new List<DataModelDefaultParameter>()
                    {
                        new DataModelDefaultParameter() { Name=nameof(ZeroDatabaseInfo.Name) ,ParameterValidate=
                        new ParameterValidate(){IsRequired=true},ValueType = typeof(string).Name }, new DataModelDefaultParameter() { Name=nameof(ZeroDatabaseInfo.Connection), ValueType = typeof(string).Name,ParameterValidate=new ParameterValidate(){IsRequired=true}},

                         new DataModelDefaultParameter() { Name=nameof(ZeroDatabaseInfo.DbType) ,ValueType = typeof(int).Name,ParameterValidate=new ParameterValidate(){
                         IsRequired=true
                         }},

                        new DataModelDefaultParameter() { Name=nameof(ZeroDatabaseInfo.Creator),
                        InsertParameter=new InsertParameter(){IsUserName=true},Value="" ,ValueType = typeof(string).Name },

                    }
                };
            });
            zeroInterfaceList.Add(data4);
        }

        private void DeleteDatabaseInfo()
        {
            //删除数据库
            ZeroInterfaceList data3 = GetNewItem(it =>
            {
                it.HttpMethod = HttpRequestMethod.GET.ToString();
                it.Id = DelDbManId;
                it.GroupName = nameof(ZeroDatabaseInfo);
                it.InterfaceCategoryId = InterfaceCategoryInitializerProvider.Id100003;
                it.Name = TextHandler.GetInterfaceListText(DeleteCateTreeId);
                it.Url = GetUrl(it, "DeleteDatabaseInfo");
                it.DataModel = new DataModel()
                {
                    TableId = EntityInfoInitializerProvider.Id_ZeroDatabaseInfo,
                    ActionType = ActionType.BizDeleteObject,
                    DefaultParameters = new List<DataModelDefaultParameter>() {
                             new DataModelDefaultParameter() { Name = nameof(ZeroDatabaseInfo.Id),   FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(long).Name,Value=0, Description = TextHandler.GetCommonText("主键", "Id") },
                              new DataModelDefaultParameter() { Name = nameof(ZeroDatabaseInfo.IsDeleted),   FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(bool).Name,Value="true", Description = TextHandler.GetCommonText("是否删除", "IsDeleted") }
                         }
                };
            });
            zeroInterfaceList.Add(data3);
        }

        private void GetDatabaseInfoList()
        {
            //获取数据库列表
            ZeroInterfaceList data2 = GetNewItem(it =>
            {
                it.HttpMethod = HttpRequestMethod.GET.ToString();
                it.Id = DbManId;
                it.GroupName = nameof(ZeroDatabaseInfo);
                it.InterfaceCategoryId = InterfaceCategoryInitializerProvider.Id100003;
                it.Name = TextHandler.GetInterfaceListText(IntCatePageListId);
                it.Url = GetUrl(it, "GetDatabaseInfoList");
                it.CustomResultModel = new ResultModel()
                {
                    ResultType = ResultType.Grid,
                    ResultColumnModels=new List<ResultColumnModel>() 
                    {
                        new ResultColumnModel(){  PropertyName= nameof(ZeroDatabaseInfo.DbType) , ConvertType=typeof(DbType),ConvertType2=typeof(string), ResultColumnType= ResultColumnType.ConvertDefault }
                    }
                };
                it.DataModel = new DataModel()
                {
                    CommonPage = new DataModelPageParameter
                    {
                        PageSize = 20,
                        PageNumber = 1
                    },
                    Columns = new List<DataColumnParameter>()
                    {

                        new DataColumnParameter(){
                            PropertyName= nameof(ZeroDatabaseInfo.Id) ,
                            Description=TextHandler.GetCommonText("ID", "Primary key")
                        },
                        new DataColumnParameter(){
                            PropertyName= nameof(ZeroDatabaseInfo.Name) ,
                            Description=TextHandler.GetCommonText("库说明", "Name")
                        },
                        new DataColumnParameter(){
                            PropertyName= nameof(ZeroDatabaseInfo.DbType) ,
                            Description=TextHandler.GetCommonText("类型", "Type")
                        },
                       new DataColumnParameter(){
                            PropertyName= nameof(ZeroDatabaseInfo.Connection) ,
                            Description=TextHandler.GetCommonText("字符串", "Connection")
                        },
                        new DataColumnParameter(){
                            PropertyName=nameof(ZeroDatabaseInfo.IsInitialized) ,
                            Description=TextHandler.GetCommonText("系统数据", "System data")
                        },
                    },
                    TableId = EntityInfoInitializerProvider.Id_ZeroDatabaseInfo,
                    ActionType = ActionType.QueryCommon,
                    DefaultParameters = new List<DataModelDefaultParameter>() {

                             new DataModelDefaultParameter() { Name = nameof(ZeroDatabaseInfo.Name),   FieldOperator=FieldOperatorType.Like,  ValueType = typeof(string).Name,Value=null , Description = TextHandler.GetCommonText("库说明", "Name") },
                             new DataModelDefaultParameter() { Name=nameof(DataModelPageParameter.PageNumber) ,Value=1,FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(long).Name, Description = TextHandler.GetCommonText("第几页", "Page number") },
                             new DataModelDefaultParameter() { Name=nameof(DataModelPageParameter.PageSize) ,Value=20,FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(long).Name, Description = TextHandler.GetCommonText("每页几条", "Pageize") },
                             new DataModelDefaultParameter() { Name = nameof(ZeroInterfaceCategory.IsDeleted),   FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(bool).Name,Value="false",ValueIsReadOnly=true, Description = TextHandler.GetCommonText("IsDeleted", "IsDeleted") },
                    }
                };
            });
            zeroInterfaceList.Add(data2);
        }

        private void GetDatabaseInfoAllList()
        {
            //获取数据库所有
            ZeroInterfaceList data1 = GetNewItem(it =>
            {
                it.HttpMethod = HttpRequestMethod.GET.ToString();
                it.Id = GetDbAllId;
                it.GroupName = nameof(ZeroDatabaseInfo);
                it.InterfaceCategoryId = InterfaceCategoryInitializerProvider.Id100004;
                it.Name = TextHandler.GetInterfaceListText(GetDbAllId);
                it.Url = GetUrl(it, "GetDatabaseInfoAllList");
                it.DataModel = new DataModel()
                {
                    TableId = EntityInfoInitializerProvider.Id_ZeroDatabaseInfo,
                    ActionType = ActionType.QueryCommon,
                    DefaultParameters = new List<DataModelDefaultParameter>()
                    {
                        new DataModelDefaultParameter() { Name = nameof(ZeroInterfaceCategory.IsDeleted),   FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(bool).Name,Value="false",ValueIsReadOnly=true, Description = TextHandler.GetCommonText("IsDeleted", "IsDeleted") },
                    }
                };
            });
            zeroInterfaceList.Add(data1);
        }
    }
}
