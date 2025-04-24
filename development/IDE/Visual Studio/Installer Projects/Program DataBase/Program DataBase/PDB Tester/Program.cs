using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PDB_Tester
{
    static class Program
    {
        //이벤트 클래스(UI 예외)
        static void exceptionDump(object sender, System.Threading.ThreadExceptionEventArgs args)
        {
            Exception e = args.Exception;

            Console.WriteLine($"[{MethodBase.GetCurrentMethod().Name}] errMsg : {e.Message}");
            Console.WriteLine($"[{MethodBase.GetCurrentMethod().Name}] errPos : {e.TargetSite}");

            PDB_Tester.Minidump.install_self_mini_dump();
        }

        //이벤트 클래스(처리되지 않은 예외)
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception) args.ExceptionObject;

            Console.WriteLine($"[{MethodBase.GetCurrentMethod().Name}] errMsg : {e.Message}");
            Console.WriteLine($"[{MethodBase.GetCurrentMethod().Name}] errPos : {e.TargetSite}");

            PDB_Tester.Minidump.install_self_mini_dump();
        }

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Console.WriteLine("Event Attatched");
            //이벤트 추가
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(exceptionDump);

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
