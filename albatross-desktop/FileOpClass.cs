﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Collections;
using System.Data.OleDb;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;
using System.Diagnostics;

namespace albatross_desktop
{
    class FileOpClass
    {
        //open
        public static DataTable readXml(string fname)
        {
            DataTable dt = new DataTable(Path.GetFileName(fname));
            XDocument doc = XDocument.Load(fname);
            bool colFinish = false;
            foreach (var item in doc.Root.Elements())
            {
                if (!colFinish)
                {
                    foreach (var attr in item.Attributes())
                    {
                        dt.Columns.Add(attr.Name.ToString());
                    }
                    colFinish = true;
                }
                DataRow dr = dt.NewRow();
                foreach (var attr in item.Attributes())
                {
                    dr[attr.Name.ToString()] = attr.Value;
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public static DataTable readExcel(string fname)
        {
            DataTable dt = new DataTable(Path.GetFileName(fname));
            string connStr = "";
            string fileType = System.IO.Path.GetExtension(fname);
            if (string.IsNullOrEmpty(fileType))
            {
                return null;
            }

            if (fileType == ".xls")
                connStr = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + fname + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";
            else
                connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + fname + ";" + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";
            string sql_F = "Select * FROM [{0}]";

            OleDbConnection conn = null;
            OleDbDataAdapter da = null;
            DataTable dtSheetName = null;
            try
            {
                // 初始化连接，并打开
                conn = new OleDbConnection(connStr);
                conn.Open();
                // 获取数据源的表定义元数据                        
                string SheetName = "";
                dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                // 初始化适配器
                da = new OleDbDataAdapter();
                for (int i = 0; i < dtSheetName.Rows.Count; i++)
                {
                    SheetName = (string)dtSheetName.Rows[i]["TABLE_NAME"];
                    if (SheetName.Contains("$"))
                    {
                        SheetName = SheetName.Replace("'", "");
                        //if (!SheetName.EndsWith("$"))
                        if (SheetName.Contains("Sheet"))
                        {
                            continue;
                        }
                    }
                    da.SelectCommand = new OleDbCommand(String.Format(sql_F, SheetName), conn);
                    DataSet dsItem = new DataSet();
                    da.Fill(dsItem, SheetName);
                    dt = dsItem.Tables[0].Copy();
                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // 关闭连接
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    da.Dispose();
                    conn.Dispose();
                }
            }
            return dt;
        }

        public static DataTable readExcel2(string fname)
        {
            DataTable dt = readExcel(fname);

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("id");
            dt2.Columns.Add("type1");
            dt2.Columns.Add("x");
            dt2.Columns.Add("y");
            dt2.Columns.Add("x1");
            dt2.Columns.Add("y1");
            dt2.Columns.Add("flag");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string tmpstr = dt.Rows[i]["DEFAULT_MON_UNIT"].ToString();
                string[] tmpstrarr = tmpstr.Split('/');
                for (int j = 0; j < tmpstrarr.Count(); j++)
                {
                    DataRow dr = dt2.NewRow();
                    dr["id"] = dt.Rows[i]["ID"];
                    if (tmpstrarr[j].Length <= 0)
                    {
                        continue;
                    }
                    string[] tmpstrarr2 = tmpstrarr[j].Split(',');
                    if (tmpstrarr2.Count() > 3)
                    {
                        dr["type1"] = tmpstrarr2[0];
                        dr["x"] = tmpstrarr2[1];
                        dr["y"] = tmpstrarr2[2];
                        dr["x1"] = tmpstrarr2[3];
                        if (tmpstrarr2.Count() > 4)
                            dr["y1"] = tmpstrarr2[4];
                        if (tmpstrarr2.Count() > 5)
                            dr["flag"] = tmpstrarr2[5];
                    }
                    else
                    {
                        dr["type1"] = tmpstrarr2[0];
                        dr["x"] = tmpstrarr2[1];
                        dr["y"] = tmpstrarr2[2];
                    }
                    dt2.Rows.Add(dr);
                }
            }
            return dt2;
        }

        public static DataTable readExcel3(string fname)
        {
            DataTable dt = readExcel(fname);

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("id");

            for (int tt = 0; tt < 10; tt++)
            {
                for (int ss = 0; ss < 12; ss++)
                {
                    string tmpcolname = "a" + (tt * 100 + ss).ToString();
                    if (!dt2.Columns.Contains(tmpcolname))
                    {
                        dt2.Columns.Add(tmpcolname);
                    }
                }
            }
            

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string tmpstr = dt.Rows[i]["MON_HERO"].ToString();
                string[] tmpstrarr = tmpstr.Split('/');
                for (int j = 0; j < tmpstrarr.Count(); j++)
                {
                    if (tmpstrarr[j].Length <= 0)
                    {
                        continue;
                    }
                    DataRow dr = dt2.NewRow();
                    string[] tmpstrarr2 = tmpstrarr[j].Split(',');
                    for (int k = 0; k < tmpstrarr2.Count(); k++)
                    {
                        string tmpcolname = "a" + (j*100+k).ToString();
                        if (!dt2.Columns.Contains(tmpcolname))
                        {
                            dt2.Columns.Add(tmpcolname);
                        }
                        dr["id"] = dt.Rows[i]["ID"];
                        dr[tmpcolname] = tmpstrarr2[k];
                    }
                    dt2.Rows.Add(dr);
                }
            }
            return dt2;
        }

        public static DataTable OpenExcel(string fname)
        {
            object missing = System.Reflection.Missing.Value;
            Excel.Application excel = new Excel.Application();//lauch excel application
            if (excel == null)
            {
                return null;
            }
            else
            {
                excel.Visible = false;
                excel.UserControl = true;
                // 以只读的形式打开EXCEL文件
                Excel.Workbook wb = excel.Application.Workbooks.Open(fname, missing, true, missing, missing, missing,
                    missing, missing, missing, true, missing, missing, missing, missing, missing);
                //取得第一个工作薄
                Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets.get_Item(1);

                //取得总记录行数   (包括标题列)
                int rowsint = ws.UsedRange.Cells.Rows.Count; //得到行数
                int columnsint = ws.UsedRange.Cells.Columns.Count; //得到列数

                //取得数据范围区域 (不包括标题列) 
                string xx = ((char)('A' + columnsint)).ToString() + rowsint.ToString();
                Excel.Range rng1 = ws.Cells.get_Range("D4", xx);
                object[,] arrDataItem = (object[,])rng1.Value2; //get range's value

                object[,] arrToolTip = ws.Cells.get_Range("D2", ('A' + columnsint).ToString() + "2").Value2;
                object[,] arrHeadName = ws.Cells.get_Range("D3", ('A' + columnsint).ToString() + "3").Value2;
            }
            excel.Quit(); 
            excel = null;
            Process[] procs = Process.GetProcessesByName("excel");
            foreach (Process pro in procs)
            {
                pro.Kill();//没有更好的方法,只有杀掉进程
            }
            GC.Collect();
            return null;
        }

        public static DataTable readJson(string fname)
        {
            DataTable dt = new DataTable(Path.GetFileName(fname));
            string buffer = null;
            buffer = File.ReadAllText(fname);
            try
            {
                dt = JsonConvert.DeserializeObject<DataTable>(buffer);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("error when convert json: " + ex.ToString());
                JObject jo = JsonConvert.DeserializeObject(buffer) as JObject;
                if (jo == null)
                {
                    return null;
                }
                var s = from p in jo.Children()
                        select p;
                bool gotheader = false;
                List<string> strList = new List<string>();
                foreach (var item in s)
                {
                    //as a row
                    JToken record = item as JToken;
                    foreach (var subitem in record)
                    {
                        int headerindex = 0;
                        var subs = from q in subitem.Children()
                                   select q;
                        //header
                        if (!gotheader)
                        {
                            foreach (var subsubitem in subs)
                            {
                                //if colname exists
                                if (strList.IndexOf(subsubitem.ToString())>=0)
                                {
                                    strList.Add(subsubitem.ToString()+"2");
                                    dt.Columns.Add(subsubitem.ToString()+"2");
                                }
                                else
                                {
                                    strList.Add(subsubitem.ToString());
                                    dt.Columns.Add(subsubitem.ToString());
                                }
                            }
                            gotheader = true;
                            continue;
                        }
                        DataRow dr = dt.NewRow();
                        //as a cell
                        foreach (var subsubitem in subs)
                        {
                            dr[strList[headerindex]] = subsubitem.ToString();
                            headerindex++;
                        }
                        dt.Rows.Add(dr);
                    }
                }
            }
            return dt;
        }

        #region "save"
        public static void saveXml(string fname, DataTable dt)
        {
            /*progressBar1.Visible = true;
            ds.WriteXml(fname);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                progressBar1.Value += 100 / ds.Tables[0].Rows.Count;
            }
            MessageBox.Show("数据已经成功导出到<" + fname, ">导出完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar1.Value = 0;
            progressBar1.Visible = false;*/
            //1、创建XML对象
            XDocument xdocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("this is comment region"));
            //2、创建跟节点
            XElement eRoot = new XElement("basenode");
            //添加到xdoc中
            xdocument.Add(eRoot);
            //3、添加子节点
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                XElement ele1 = new XElement("node");
                //ele1.Value = "内容1";
                eRoot.Add(ele1);
                for (int k = 0; k < dt.Columns.Count; k++)
                {
                    //4、为ele1节点添加属性
                    XAttribute attr = new XAttribute(dt.Columns[k].ColumnName, dt.Rows[j][dt.Columns[k].ColumnName].ToString());
                    ele1.Add(attr);
                }
            }
            //5、快速添加子节点方法
            //eRoot.SetElementValue("子节点2", "内容2");
            //6、快速添加属性
            //ele1.SetAttributeValue("id", 12);
            //7、最后保存到文件，也可以写入到流中。
            xdocument.Save(fname);
        }

        public static void saveExcel03(object obj, DataTable dt)
        {
            SaveFileDialog saveFileDialog = obj as SaveFileDialog;
            Stream myStream;
            myStream = saveFileDialog.OpenFile();
            //StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding("gb2312"));
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));
            string str = "";
            try
            {
                //写标题
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (i > 0)
                    {
                        str += "\t";
                    }
                    str += dt.Columns[i].ColumnName;
                }
                sw.WriteLine(str);
                //写内容
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    string tempStr = "";
                    for (int k = 0; k < dt.Columns.Count; k++)
                    {
                        if (k > 0)
                        {
                            tempStr += "\t";
                        }
                        tempStr += dt.Rows[j][dt.Columns[k].ColumnName].ToString();
                    }

                    sw.WriteLine(tempStr);
                }
                sw.Close();
                myStream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sw.Close();
                myStream.Close();
            }
        }

        public static bool saveExcel07(string fileName, DataTable dt, bool isShowExcel = false)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                if (app == null)
                {
                    return false;
                }

                app.Visible = isShowExcel;
                Excel.Workbooks workbooks = app.Workbooks;
                Excel._Workbook workbook = workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Sheets sheets = workbook.Worksheets;
                Excel._Worksheet worksheet = (Excel._Worksheet)sheets.get_Item(1);
                if (worksheet == null)
                {
                    return false;
                }
                string sLen = "";
                //取得最后一列列名
                char H = (char)(64 + dt.Columns.Count / 26);
                char L = (char)(64 + dt.Columns.Count % 26);
                if (dt.Columns.Count < 26)
                {
                    sLen = L.ToString();
                }
                else
                {
                    sLen = H.ToString() + L.ToString();
                }


                //标题
                string sTmp = sLen + "1";
                Excel.Range ranCaption = worksheet.get_Range(sTmp, "A1");
                string[] asCaption = new string[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    asCaption[i] = dt.Columns[i].ColumnName;
                }
                ranCaption.Value2 = asCaption;

                //数据
                object[] obj = new object[dt.Columns.Count];
                for (int r = 0; r < dt.Rows.Count - 1; r++)
                {
                    for (int l = 0; l < dt.Columns.Count; l++)
                    {
                        //if (g_dt.Rows[r][g_dt.Columns[l].ColumnName].GetType() == typeof(DateTime))
                        //if (g_dt[l, r].ValueType == typeof(DateTime))
                        //{
                        //obj[l] = g_dt[l, r].Value.ToString();
                        obj[l] = dt.Rows[r][dt.Columns[l].ColumnName].ToString();
                        //}
                        //else
                        //{
                        //    obj[l] = g_dt.Rows[j][g_dt.Columns[k].ColumnName];
                        //}
                    }
                    string cell1 = sLen + ((int)(r + 2)).ToString();
                    string cell2 = "A" + ((int)(r + 2)).ToString();
                    Excel.Range ran = worksheet.get_Range(cell1, cell2);
                    ran.Value2 = obj;
                }
                //保存
                workbook.SaveCopyAs(fileName);
                workbook.Saved = true;
            }
            finally
            {
                //关闭
                app.UserControl = false;
                app.Quit();
            }
            return true;
        }
        #endregion

        public static bool rangeDt(DataTable src, ref DataTable dest, ref ArrayList tooltiplist, ref ArrayList tbtip, string g_iniFile)
        {
            try
            {
                int irowstart = 0;
                int icolstart = 0;
                string rowstart = Config.ReadIniKey("dataoff", "rowstart", g_iniFile);
                if (rowstart.Length > 0)
                {
                    irowstart = int.Parse(rowstart);
                }
                string colstart = Config.ReadIniKey("dataoff", "colstart", g_iniFile);
                if (colstart.Length > 0)
                {
                    icolstart = int.Parse(colstart);
                }
                if (irowstart >= 1)
                {
                    //only tooltip line
                    if (irowstart == 1)
                    {
                        for (int i = 0; i < src.Columns.Count; i++)
                        {
                            tooltiplist.Add(src.Columns[i].ColumnName);
                        }
                    }
                    else //table comment got
                    {
                        tbtip.Add(src.Columns[0].ColumnName);
                        for (int i = 0; i < src.Columns.Count; i++)
                        {
                            tooltiplist.Add(src.Rows[0][src.Columns[i].ColumnName].ToString());
                        }
                    }
                    if (src.Rows.Count > 0)
                    {
                        //if more than tooltip row, remove them
                        for (int i = 0; i < irowstart - 1; i++)
                        {
                            src.Rows.RemoveAt(0);
                        }
                        for (int i = 0; i < src.Columns.Count; i++)
                        {
                            src.Columns[i].ColumnName = src.Rows[0][src.Columns[i].ColumnName.ToString()].ToString();
                        }
                        src.Rows.RemoveAt(0);
                    }
                }
                if (icolstart > 0)
                {
                    for (int i = 0; i < icolstart; i++)
                    {
                        src.Columns.RemoveAt(0);
                    }
                }
                dest = src.Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            return true;
        }

        public static void forbidGridViewSort(DataGridView viewer, ArrayList exclude)
        {
            if (viewer.Rows.Count < 0)
            {
                return;
            }
            for (int i = 0; i < viewer.Columns.Count; i++)
            {
                if (exclude == null || exclude.Count <= 0 || exclude.IndexOf(viewer.Columns[i].Name) >= 0)
                {
                    viewer.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }


    }
}
