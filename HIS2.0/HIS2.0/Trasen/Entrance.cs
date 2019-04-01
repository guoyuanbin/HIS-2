using System;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.IO.Compression;


namespace TraSen
{
    /// <summary>
    /// ϵͳ���
    /// </summary>
    public class Entrance
    {
        /// <summary>
        /// Ӧ�ó��������ڵ㡣
        /// </summary>
        [STAThread]
        static void Main( string[] args )
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler( CurrentDomain_AssemblyResolve );

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            

            //TrasenMainWindow.FrmMdiMainWindow.WriteFrameLocalLog( new string[] { string.Format("********************************************** Local Time : {0} **********************************************",DateTime.Now.ToString() ) }, false );

           // string clientConfigFile = TrasenFrame.Classes.Constant.ApplicationDirectory + "\\ClientConfig.ini";

            string[] ss = System.Windows.Forms.Application.ExecutablePath.Split( "\\".ToCharArray() );
           // TrasenClasses.GeneralClasses.ApiFunction.WriteIniString( "HIS_StARTUP_EXE" , "NAME" , ss[ss.Length - 1] , clientConfigFile );
            
            string serverName = "";

           // serverName = TrasenClasses.GeneralClasses.ApiFunction.GetIniString("SERVER_NAME", "NAME", clientConfigFile);
            if (serverName == "")
            {
                System.Windows.Forms.MessageBox.Show("ClientConfig.ini��[SERVER_NAME]��NAMEδ����,���������ó������õ�ǰ������", "����");
                return;
            }
            
           // string connectionString = TrasenFrame.Classes.WorkStaticFun.GetConnnectionString_Default(TrasenFrame.Classes.ConnectionType.SQLSERVER);//.GetConnnectionString(ConnectionType.SQLSERVER, serverName);


            if ( args != null && args.Length > 0 && args[0] == "IsFormUpdate" )
            {

               // TrasenMainWindow.FrmMdiMainWindow.StartupMain( "���ǿƼ���Ϣϵͳ" , TrasenFrame.Classes.ConnectionType.SQLSERVER , connectionString , "Trasen" , true , true );
                return;
            }
            
            //TrasenMainWindow.FrmMdiMainWindow.StartupMain( "���ǿƼ���Ϣϵͳ" , TrasenFrame.Classes.ConnectionType.SQLSERVER , connectionString , "Trasen" , true );
        }

  

        static System.Reflection.Assembly CurrentDomain_AssemblyResolve( object sender , ResolveEventArgs args )
        {
            string[] info = args.Name.Split( ",".ToCharArray() );
            string dllName = string.Format( "{0}.dll" , info[0] );
            string strTempAssmbPath = "";
            string systemFolder = @"D:\��˾����\TrasenHISv2.0\��׼��\Output\";
            strTempAssmbPath = System.IO.Path.Combine( systemFolder , dllName );
            return string.IsNullOrEmpty( strTempAssmbPath ) ? null : System.Reflection.Assembly.LoadFrom( strTempAssmbPath );
        }
    }
}