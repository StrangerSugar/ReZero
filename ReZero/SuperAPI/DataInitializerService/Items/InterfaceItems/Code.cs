﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReZero.SuperAPI
{
    internal partial class InterfaceListInitializerProvider
    { 
        private void AddInit_CodeList()
        {
            GetDbTypeList();
            GetNativeTypeList();
        }

        private void GetDbTypeList()
        {
            ZeroInterfaceList data = GetNewItem(it =>
            {
                it.HttpMethod = HttpRequestMethod.GET.ToString();
                it.Id = GetDbTypeListId;
                it.GroupName = nameof(EnumApi);
                it.InterfaceCategoryId = InterfaceCategoryInitializerProvider.Id100004;
                it.Name = TextHandler.GetInterfaceListText(GetDbTypeListId);
                it.Url = GetUrl(it, "GetDbTypeList");
                it.DataModel = new DataModel()
                {
                    TableId = EntityInfoInitializerProvider.Id_ZeroDatabaseInfo,
                    ActionType = ActionType.MyMethod,
                    MyMethodInfo = new MyMethodInfo()
                    {
                        MethodClassFullName = typeof(EnumApi).FullName,
                        MethodArgsCount = 0,
                        MethodName = nameof(EnumApi.GetDbTypeSelectDataSource)
                    }
                };
            });
            zeroInterfaceList.Add(data);
        }
        private void GetNativeTypeList()
        {
            ZeroInterfaceList data = GetNewItem(it =>
            {
                it.HttpMethod = HttpRequestMethod.GET.ToString();
                it.Id = GetNativeTypeId;
                it.GroupName = nameof(EnumApi);
                it.InterfaceCategoryId = InterfaceCategoryInitializerProvider.Id100004;
                it.Name = TextHandler.GetInterfaceListText(GetNativeTypeId);
                it.Url = GetUrl(it, "GetNativeTypeList");
                it.DataModel = new DataModel()
                {
                    TableId = EntityInfoInitializerProvider.Id_ZeroDatabaseInfo,
                    ActionType = ActionType.MyMethod,
                    MyMethodInfo = new MyMethodInfo()
                    {
                        MethodClassFullName = typeof(EnumApi).FullName,
                        MethodArgsCount = 0,
                        MethodName = nameof(EnumApi.GetNativeTypeSelectDataSource)
                    }
                };
            });
            zeroInterfaceList.Add(data);
        }
    }
}
