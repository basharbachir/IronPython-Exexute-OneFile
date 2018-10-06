using System;
using System.Reflection;
using IronPython.Runtime.Operations;
namespace PythonApplication1
{
    public class PythonMain
    {
        [STAThread]
        public static void Main()
        {
PythonOps.InitializeModuleEx(Assembly.Load(new byte[]{ /* put your dll bytes here*/ }), "__main__", null , false, null);    
        }
    }
}