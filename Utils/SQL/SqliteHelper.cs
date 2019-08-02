using RotatingViscometer.Nithons._190724.Lan;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace RotatingViscometer.Nithons._190724.Utils.SQL
{
    class SqliteHelper
    {
        Multi_Language mul = new Multi_Language();
        Global glb = new Global();

        /// <summary>
        /// [受保护参数]
        /// [文本值]
        /// [静态变量]
        /// 数据库连接字符串
        /// </summary>
        protected static string conStr = "Data Source = " + Application.StartupPath + @"\db\db.db;Initial Catalog = sqlite;Integrated Security = True;Max Tool Size = 10";

        /// <summary>
        /// [受保护参数]
        /// [SQLite连接]
        /// [静态变量]
        /// 数据库连接
        /// </summary>
        protected static SQLiteConnection sqlCon = new SQLiteConnection(conStr);

        /// <summary>
        /// [私有方法]
        /// [安全]
        /// 打开数据库连接
        /// </summary>
        private void Open()
        {
            if (sqlCon == null)
            {
                sqlCon.Open();
            }
            else
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
            }
        }

        /// <summary>
        /// [私有方法]
        /// [安全]
        /// 关闭数据库连接
        /// </summary>
        private void Close()
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        /// <summary>
        /// [公共方法]
        /// 数据
        /// 插入、更新、删除
        /// </summary>
        /// <param name="sqlStr"></param>
        public void ExecuteNonQuery(string sqlStr)
        {
            int l = glb.SimpLanRecord();
            try
            {
                Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlStr, sqlCon);
                cmd.ExecuteNonQuery();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), mul.Exception[l], MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// [公共方法]
        /// 数据查询
        /// 返回结果集
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        public DataTable ExecuteReader(string sqlStr)
        {
            int l = glb.SimpLanRecord();
            try
            {
                Open();
                SQLiteDataAdapter dr = new SQLiteDataAdapter(sqlStr, sqlCon);
                DataTable dt = new DataTable();
                dr.Fill(dt);
                Close();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), mul.Exception[l], MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// [公共方法]
        /// 读取
        /// 数据总条数
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        public int ExecuteScalar(string sqlStr)
        {
            int l = glb.SimpLanRecord();
            try
            {
                Open();
                SQLiteCommand cmd = new SQLiteCommand(sqlStr, sqlCon);
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                Close();

                return n;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), mul.Exception[l], MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        /// <summary>
        /// [公共方法]
        /// 事务批量统一处理
        /// </summary>
        /// <param name="sqlStrs"></param>
        /// <returns></returns>
        public bool ExecuteTransaction(string[] sqlStrs)
        {
            Open();
            SQLiteCommand cmd = new SQLiteCommand();
            SQLiteTransaction trans = sqlCon.BeginTransaction();
            try
            {
                cmd.Connection = sqlCon;
                cmd.Transaction = trans;
                foreach (var item in sqlStrs)
                {
                    cmd.CommandText = item;
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
                return true;
            }
            catch
            {
                //回滚机制
                trans.Rollback();
                return false;
            }
            finally
            {
                cmd.Dispose();
                Close();
            }
        }

        /// <summary>
        /// [公共特定方法]
        /// 读取系统语言参数
        /// 默认值为1252
        /// 英语
        /// </summary>
        /// <returns></returns>
        public int ObtainSysLang()
        {
            int res;
            string sqlStr = "SELECT Sys_LanRecord FROM SysParmsInfo";
            res = Convert.ToInt32(ExecuteReader(sqlStr).Rows[0][0]);

            return res;
        }

        /// <summary>
        /// [公共特定方法]
        /// 更新系统语言参数
        /// </summary>
        /// <param name="val">语言参数</param>
        public void UpdateSysLang(int val)
        {
            string sqlStr = "UPDATE SysParmsInfo SET Sys_LanRecord = " + val;
            ExecuteNonQuery(sqlStr);
        }
    }
}
