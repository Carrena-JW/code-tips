namespace CodeTips.Windows
{
    internal class NTFS
    {
        private const string ADS_STREAM_TAG = "fileid";


        internal bool IsNTFS(string path)
        {
            var rootPath = Path.GetPathRoot(path)!;

            var driveInfo = new DriveInfo(rootPath);

            return driveInfo.DriveFormat.Equals("ntfs", StringComparison.OrdinalIgnoreCase);
        }

        // ADS (파일변조??), 특정 메타 데이터를 저장 할 수 있음
        internal void WriteToADS(string filePath, string inputData)
        {
            var pathWithStreamTag = GenerateFilePathWithStreamTag(filePath);

            using (FileStream fs = new FileStream(pathWithStreamTag, FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(inputData);
            }
        }

        internal string ReadFromADS(string filePath)
        {
            string data = string.Empty;
            try
            {
                var pathWithStreamTag = GenerateFilePathWithStreamTag(filePath);

                using (FileStream fs = new FileStream(pathWithStreamTag, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fs))
                {
                    data = reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException)
            {
                return null; // 스트림이 존재하지 않음
            }
            return data;
        }

        private string GenerateFilePathWithStreamTag(string path)
        {
            return $"{path}:{ADS_STREAM_TAG}";
        }
    }
}
