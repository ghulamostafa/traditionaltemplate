using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI;

namespace MGas.Utility
{
    public class myUtility
    {
        string SPConstr = ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;

        #region Database Stored Procedure Related

        /// <summary>
        /// Used for calling a stored procedure for inserting or updating in the database
        /// </summary>
        /// <param name="_procedure">Stored Procedure name</param>
        /// <param name="_action">This is to what action to be performed</param>
        /// <param name="result">Output parameter result. Integer</param>
        /// <param name="message">Output parameter message. String</param>
        /// <param name="_paramaters">paramWithValues array</param>
        /// <returns></returns>
        public bool runProcedureInsert(string _procedure, string _action, string lang, ref int result, ref string message, params paramWithValues[] _paramaters)
        {
            using (SqlConnection con = new SqlConnection(SPConstr))
            {
                using (SqlCommand cmd = new SqlCommand(_procedure))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", _action);
                    cmd.Parameters.AddWithValue("@lang", lang);
                    cmd.Parameters.Add("@result", SqlDbType.BigInt).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@message", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;

                    foreach (paramWithValues item in _paramaters)
                    {
                        if (item.DataType == "DataTable")
                            cmd.Parameters.AddWithValue(item.Param, item.theValueDT);
                        else
                            cmd.Parameters.AddWithValue(item.Param, item.theValue);
                    }

                    cmd.Connection = con;
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        //Get the result output here.
                        result = int.Parse(cmd.Parameters["@result"].Value.ToString());
                        message = cmd.Parameters["@message"].Value.ToString();
                        //If Succeeds
                        Console.WriteLine("No try error.");
                        return true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                        //If the result is -1 then there have been an exception at the code level not SQL.
                        result = -1;
                        message = e.ToString();
                        //Error to show
                        return false;
                    }
                    finally
                    {
                    }

                }
            }
        }

        /// <summary>
        /// Used for calling a stored procedure for inserting or updating in the database
        /// </summary>
        /// <param name="_procedure">Stored Procedure name</param>
        /// <param name="_action">This is to what action to be performed</param>
        /// <param name="result">Output parameter result. Integer</param>
        /// <param name="message">Output parameter message. String</param>
        /// <param name="additional">Output parameter additional to message. String</param>
        /// <param name="_paramaters">paramWithValues array</param>
        /// <returns></returns>
        public bool runProcedureInsert(string _procedure, string _action, string lang, ref int result, ref string message, ref string additional, params paramWithValues[] _paramaters)
        {
            using (SqlConnection con = new SqlConnection(SPConstr))
            {
                using (SqlCommand cmd = new SqlCommand(_procedure))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", _action);
                    cmd.Parameters.AddWithValue("@lang", lang);
                    cmd.Parameters.Add("@result", SqlDbType.BigInt).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@message", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@additional", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                    foreach (paramWithValues item in _paramaters)
                    {
                        if (item.DataType == "DataTable")
                            cmd.Parameters.AddWithValue(item.Param, item.theValueDT);
                        else
                            cmd.Parameters.AddWithValue(item.Param, item.theValue);
                    }

                    cmd.Connection = con;
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        //Get the result output here.
                        result = int.Parse(cmd.Parameters["@result"].Value.ToString());
                        message = cmd.Parameters["@message"].Value.ToString();
                        additional = cmd.Parameters["@additional"].Value.ToString();
                        //If Succeeds
                        Console.WriteLine("No try error.");
                        return true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                        //If the result is -1 then there have been an exception at the code level not SQL.
                        result = -1;
                        message = e.ToString();
                        //Error to show
                        return false;
                    }
                    finally
                    {
                    }

                }
            }
        }

        /// <summary>
        /// Used for calling a stored procedure for selecting from database
        /// </summary>
        /// <param name="_procedure">Stored Procedure name</param>
        /// <param name="_action">This is to what action to be performed</param>
        /// <param name="result">Output parameter result. Integer</param>
        /// <param name="message">Output parameter message. String</param>
        /// <param name="_ds">Dataset containing multiple tables as a result of multiple select queries from database</param>
        /// <param name="_paramaters">paramWithValues array</param>
        /// <returns></returns>
        public bool runProcedureSelect(string _procedure, string _action, ref int result, ref string message, ref DataSet _ds, params paramWithValues[] _parameters)
        {
            using (SqlConnection con = new SqlConnection(SPConstr))
            {
                using (SqlCommand cmd = new SqlCommand(_procedure))
                {
                    cmd.Parameters.AddWithValue("@Action", _action);
                    cmd.Parameters.Add("@result", SqlDbType.BigInt).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@message", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;
                    foreach (paramWithValues param in _parameters)
                    {
                        if (param.DataType == "DataTable")
                            cmd.Parameters.AddWithValue(param.Param, param.theValueDT);
                        else
                            cmd.Parameters.AddWithValue(param.Param, param.theValue);
                    }
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(_ds);

                        result = int.Parse(cmd.Parameters["@result"].Value.ToString());
                        message = (string)cmd.Parameters["@message"].Value;
                    }
                }
                con.Close();
                //For Closing the con connection.
            }
            return false;
        }

        /// <summary>
        /// Used for calling a stored procedure for selecting from database
        /// </summary>
        /// <param name="_procedure">Stored Procedure name</param>
        /// <param name="_action">This is to what action to be performed</param>
        /// <param name="result">Output parameter result. Integer</param>
        /// <param name="message">Output parameter message. String</param>
        /// <param name="_paramaters">paramWithValues array</param>
        /// <returns></returns>
        public bool runProcedureSelect(string _procedure, string _action, ref int result, ref string message, params paramWithValues[] _parameters)
        {
            using (SqlConnection con = new SqlConnection(SPConstr))
            {
                using (SqlCommand cmd = new SqlCommand(_procedure))
                {
                    cmd.Parameters.AddWithValue("@Action", _action);
                    cmd.Parameters.Add("@result", SqlDbType.BigInt).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@message", SqlDbType.NVarChar, 150).Direction = ParameterDirection.Output;
                    foreach (paramWithValues param in _parameters)
                    {
                        if (param.DataType == "DataTable")
                            cmd.Parameters.AddWithValue(param.Param, param.theValueDT);
                        else
                            cmd.Parameters.AddWithValue(param.Param, param.theValue);
                    }
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Connection = con;
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();

                        result = int.Parse(cmd.Parameters["@result"].Value.ToString());
                        message = (string)cmd.Parameters["@message"].Value;
                    }
                }
                con.Close();
                //For Closing the con connection.
            }
            return false;
        }

        /// <summary>
        /// This method is used for converting a ResponseClass object into an XML form string for Mobile Services
        /// </summary>
        /// <param name="resp">ResponseClass object to be converted into a string</param>
        /// <returns></returns>
        internal string RespToXMLString(ResponseClass resp)
        {
            string strXML = "";
            strXML += "<response>";
            strXML += "<result>" + resp.Result + "</result>";
            strXML += "<message>" + resp.Message + "</message>";
            strXML += "<strVal>" + resp.StrVal + "</strVal>";
            strXML += "<Ds>";
            // Run a loop to loop all the Records in all of the Tables in the given DS
            int tc = 0; //DataTable count
            int rc = 0; //Row Count
            foreach (DataTable dt in resp.Ds.Tables)
            {
                // Beginning of a Data Table
                strXML += "<DataTable" + tc + ">";

                //DataView dv = dt.AsDataView();
                //foreach (DataColumn dc in dv)
                //{
                //    strXML += "<" + dc.ColumnName + ">";
                //    strXML += "";
                //    strXML += "</" + dc.ColumnName + ">";
                //}

                foreach (DataRow dr in dt.Rows)
                {
                    strXML += "<Item>";
                    DataRowView drv = dt.DefaultView[dt.Rows.IndexOf(dr)];
                    foreach (DataColumn dc in drv.DataView.ToTable().Columns)
                    {
                        //Beginning and Ending of a Column tag.
                        strXML += "<" + dc.ColumnName + ">";
                        strXML += dr[dc.ColumnName].ToString();
                        strXML += "</" + dc.ColumnName + ">";
                    }
                    strXML += "</Item>";
                    rc++; //Increment of Row Count
                }
                // Closing of a Data Table
                strXML += "</DataTable" + tc + ">";
                rc = 0;
                tc++; //Increment of Table Count
            }
            strXML += "</Ds>";
            strXML += "</response>";
            return strXML;
        }

        #endregion

        #region Value Checks

        /// <summary>
        /// This checks if the passed string value is an integer value or not
        /// </summary>
        /// <param name="value">String value</param>
        /// <returns></returns>
        static internal bool IsInteger(string value)
        {
            int x = 0;
            try
            {
                x = int.Parse(value);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// For differentiating if the passed value is in Arabic or English
        /// </summary>
        /// <param name="value">String value</param>
        /// <returns></returns>
        public bool ContainsArabicCharacter(string value)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(value);
            for (int i = 1; i < bytes.Length; i += 2)
                if (bytes[i] == 6)  //0x06** is arabic code page
                    return true;
            return false;
        }

        #endregion

        #region JavaScript
        
        /// <summary>
        /// This is for popping a JavaScript alert.
        /// </summary>
        /// <param name="message">The message to be displayed</param>
        /// <param name="page">The page as reference on which to appear</param>
        public void Alert(string message, ref Page page)
        {
            //string themessage = "<script language='javascript' ID='script1'>" + "window.open('PictureUpload.aspx','new window', 'top=90, left=200, width=850, height=600, dependant=no, location=0, alwaysRaised=no, menubar=no, resizeable=no, scrollbars=n, toolbar=no, status=no, center=yes')" + "</script>";
            //        ScriptManager.RegisterClientScriptBlock((page), page.GetType(), "Script1", message, false);


            string theMessage = (Convert.ToString("alert('") + message) + "')";
            ScriptManager.RegisterClientScriptBlock(page, page.GetType(), "alert", theMessage, true);
        }

        #endregion

    }
}