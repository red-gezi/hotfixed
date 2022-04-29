using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

class DllManager
{
    static byte[] data=new byte[] { } ;
    static Assembly MoveDll => Assembly.Load(new WebClient().DownloadData(@"http://127.0.0.1:49514/Library/ScriptAssemblies/Move.dll"));
    public static Type GetScript() => MoveDll.GetType("CubeMove");
    public static bool Checked()
    {
        var newData = new WebClient().DownloadData(@"http://127.0.0.1:49514/Library/ScriptAssemblies/Move.dll");
        if(newData.Length!=data.Length)
        {
            data = newData;
            return true;
        }
        return false;
    }
}