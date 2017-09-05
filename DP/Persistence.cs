using System.IO;

namespace DP
{
    public class Persistence
    {
        public void Save(Journal j, string filename, bool overwrite = false)
        {
            if(overwrite || !File.Exists(filename))
                File.WriteAllText(filename,j.ToString());
        }
    }
}
