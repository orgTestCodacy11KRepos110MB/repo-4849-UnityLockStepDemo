﻿//using CDatabase;
using CDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DataBaseService
{
    public static IDatabase database;
    public static void Init()
    {
        Debug.Log("开始连接数据库~~~");
        long time = ServiceTime.GetServiceTime();

        DbConfig config = new DbConfig();


        database = DatabaseFactory.CreateDatabase(config, DbConfig.DbType.MYSQL);

        try
        {
            database.Open();

            time = ServiceTime.GetServiceTime() - time;

            Debug.Log("数据库连接成功 用时" + time +"ms");
        }
        catch (DatabaseException e)
        {
            Debug.LogError("错误代码：" + e.GetErrorCode() + "，错误信息：" + e.GetErrorMsg());
        }
    }


}
