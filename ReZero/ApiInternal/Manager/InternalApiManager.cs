﻿using System;
using System.Collections.Generic;
using System.Text; 

namespace ReZero
{
    public class InternalApiManager
    {
        List<ZeroInterfaceList> zeroInterfaceList = new List<ZeroInterfaceList>() { };
        List<ZeroInterfaceCategory>  zeroInterfaceCategory = new List<ZeroInterfaceCategory>() { };
        public void Initialize(ReZeroOptions options)
        {
            var db = App.PreStartupDb;
            db!.Deleteable<ZeroInterfaceCategory>().Where(it => it.IsInitialized).ExecuteCommand();
            var categoryProvider = new InterfaceCategoryProvider(zeroInterfaceCategory);
            categoryProvider.Set();
            db!.Storageable(zeroInterfaceCategory).ExecuteCommand();


            var interfaceListProvider = new InterfaceListProvider(zeroInterfaceList);
            interfaceListProvider.Set(); 
            db!.Storageable(zeroInterfaceList).ExecuteCommand();

            var icon = new IconProvider();
            //db.Storageable(icon.GetDatas()).ExecuteCommand();
        } 
    }
}
