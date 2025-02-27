﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReZero.SuperAPI
{
    public partial class MethodApi 
    {
        public bool TestDb(long Id)
        {
            SqlSugarClient? db = App.GetDbById(Id);
            if (db == null)
            {
                return false;
            }
            else
            {
                return db.Ado.IsValidConnection();
            }
        }

        public object CreateDb(long dbId)
        {
            try
            {
                SqlSugarClient? db = App.GetDbById(dbId);
                db!.DbMaintenance.CreateDatabase();
                return true;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public  object GetImportTables(long databaseId,string tableName)
        { 
            var db = App.GetDbById(databaseId);
            var entitys = App.Db.Queryable<ZeroEntityInfo>()
                .Where(it=>it.IsDeleted==false) 
                .Where(it => it.DataBaseId == databaseId).ToList();
            var tables = db!.DbMaintenance.GetTableInfoList(false).Where(it => !it.Name.ToLower().StartsWith("zero_")).ToList(); 
            var result = tables
                            .Where(it=> !entitys.Any(s=>s.DbTableName!.EqualsCase(it.Name))).ToList();
            if (!string.IsNullOrEmpty(tableName)) 
            {
                result=result.Where(it => it.Name.ToLower().Contains(tableName.ToLower())).ToList();
            }
            return  result ;
        }
        public object GetTables(long databaseId,string tableName)
        {
            var db = App.GetDbById(databaseId);
            var entitys = App.Db.Queryable<ZeroEntityInfo>()
                .Where(it => it.IsDeleted == false)
                .Where(it => it.DataBaseId == databaseId).ToList()
                .Where(it => !it.DbTableName!.ToLower().StartsWith("zero_"));
            var result = entitys.Select(it => new DbTableInfo()
            {
                Id = it.Id,
                Name=it.ClassName,
                Description=it.Description
            }).ToList();
            return result;
        }
    }
}
