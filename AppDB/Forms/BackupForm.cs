using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;

namespace AppDB.Forms
{
    public partial class BackupForm : MaterialForm
    {
        public NpgsqlConnection m_NpgsqlConnection;
        string strConnection = "";
        string strServer = string.Empty;
        string strPort = string.Empty;
        string strDatabaseName = string.Empty;
       StringBuilder sbPG_dumpPath = new StringBuilder();
        String strPG_dumpPath = String.Empty;
        string strInstallLocation = string.Empty;

        public BackupForm()
        {
            try
            {
                InitializeComponent();
                strConnection = "Server=localhost;Port=5432;Database=postgres;Userid=postgres;Password=123;";
                               
                CheckPostgres();
            }
            catch (Exception ex)
            { }

        }
        void CheckPostgres()
        {
            try
            {
                if (sbPG_dumpPath.Length == 0)
                {
                     bool bPostgresService = false;
                    ServiceController[] services = ServiceController.GetServices();
                    // try to find service name
                    foreach (ServiceController service in services)
                    {
                        if (service.ServiceName.Contains("postgre") == true)
                        {
                            bPostgresService = true;
                            break;
                        }
                    }
                    if (bPostgresService == true)
                    {
                        PG_DumpExePath();
                    }
                   
                }
            }
            catch (Exception)
            { }

        }

        private void PG_DumpExePath()
        {
            try
            {
           
                if (sbPG_dumpPath.Length == 0)
                {
                   
                    if (strPG_dumpPath == string.Empty)
                    {
                        strPG_dumpPath = LookForFile("pg_dump.exe");
                                           }

                    int a = strPG_dumpPath.IndexOf(":\\", 0);
                    a = a + 2;
                    string strSub = strPG_dumpPath.Substring(0, (a - 2));
                    strPG_dumpPath = strPG_dumpPath.Substring(a, (strPG_dumpPath.Length - a));

                    StringBuilder sbSB1 = new StringBuilder(strPG_dumpPath);
                    sbSB1.Replace("\\", "\r\n\r\ncd ");

                    StringBuilder sbSB2 = new StringBuilder("cd /D ");
                    sbSB2.Append(strSub);
                    sbSB2.Append(":\\");

                    sbSB1 = sbSB2.Append(sbSB1);
                    sbSB1 = sbSB1.Remove((sbSB1.Length - 3), 3);
                    sbPG_dumpPath = sbSB1;
                    strPG_dumpPath = sbSB1.ToString();
                }
            }
            catch (Exception )
            { }
        }

        private string LookForFile(string strFileName)
        {
            string strPG_dumpPath = string.Empty;
            try
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    strPG_dumpPath = performFileSearchTask(drive.Name, strFileName);
                    if (strPG_dumpPath.Length != 0)
                        break;
                }
            }
            catch { }
            return strPG_dumpPath;
        }

        private string performFileSearchTask(string dirName, string strfileName)
        {
            try
            {
                if (strPG_dumpPath.Length == 0)
                {
                    try
                    {

                        foreach (string ddir in Directory.GetDirectories(dirName))
                        {
                            System.Security.Permissions.FileIOPermission ReadPermission =
                                new System.Security.Permissions.FileIOPermission(System.Security.Permissions.FileIOPermissionAccess.Write, ddir);
                            if (System.Security.SecurityManager.IsGranted(ReadPermission))
                            {
                                try
                                {
                                    foreach (string dfile in Directory.GetFiles(ddir, strfileName))
                                    {
                                        strPG_dumpPath = ddir + "\\";
                                        if (strPG_dumpPath.Length > 0)
                                        {
                                            strInstallLocation = strPG_dumpPath;
                                            break;
                                        }
                                    }
                                    if (strPG_dumpPath.Length == 0)
                                        performFileSearchTask(ddir, strfileName);
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (strPG_dumpPath != string.Empty)
                                break;
                        }
                    }
                    catch (Exception )
                    { }

                }

            }
            catch (Exception )
            { }
            return strPG_dumpPath;
        }

        public DataSet GetData(string strQuery)
        {
            DataSet objDataSet = new DataSet();
            try
            {
                // if (m_NpgsqlConnection == null)
                {
                    m_NpgsqlConnection = new NpgsqlConnection(strConnection);
                }

                NpgsqlDataAdapter objSqlAdapter = new NpgsqlDataAdapter(strQuery, m_NpgsqlConnection);
                objSqlAdapter.Fill(objDataSet);
                return objDataSet;
            }
            catch (Exception )
            {
                objDataSet = null;
                return objDataSet;
            }
        }
    

        void GetDB()
        {
            try
            {
                string DataBase = string.Empty;
                DataSet dsDB = new DataSet();
                strConnection = "Server=localhost;Port=5432;DataBase = postgres; UserId = postgres;Password=123;";

                dsDB = GetData("Select datname FROM pg_database where datistemplate IS FALSE AND datname!='postgres' AND datname ='AutoSalonDB';");
                if (dsDB != null)
                {
                    DataBase = dsDB.Tables[0].Rows[0][0].ToString();
                    strDatabaseName = DataBase;
                }

            }
            catch (Exception)
            {  }
        }
       
        private void btnSelectBackUp_Click(object sender, EventArgs e)
        {
            try {
                GetDB();
                txtLocationBackup.Text = string.Empty;
                btnMakeBackup.Enabled = false;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Расположение для резервной копии";
                    sfd.Filter = "Backup File|*.backup";
                   sfd.FilterIndex = 0;
                sfd.RestoreDirectory = true;
                       string fileName = strDatabaseName + "_Backup" + "_" + System.DateTime.Now.ToString("ddMMyyyy_HHmm");
                    sfd.FileName = fileName;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        txtLocationBackup.Text = sfd.FileName;
                        btnMakeBackup.Enabled = true;
                    }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }

        private void btnMakeBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLocationBackup.Text == string.Empty)
                {
                    MessageBox.Show("Выберите место куда сохранить");
                    return;
                }
                StreamWriter sw = new StreamWriter("DBBackup.bat");
                StringBuilder strSB = new StringBuilder(strPG_dumpPath);
                if (strSB.Length != 0)
                {
                    strSB.Append("pg_dump.exe --host localhost --port 5432 --username postgres --format custom --blobs --verbose --file ");
                    strSB.Append("\"" + txtLocationBackup.Text + "\"");
                    strSB.Append(" \""+strDatabaseName+"\r\n\r\n");
                    sw.WriteLine(strSB);
                    sw.Dispose();
                    sw.Close();
                    Process processDB = Process.Start("DBBackup.bat");
                    do
                    {
                    }
                    while (!processDB.HasExited);
                    {
                        MessageBox.Show(strDatabaseName + " Успешно создана резервная копия в " + txtLocationBackup.Text);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, укажите местоположение для резервного копирования!");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
