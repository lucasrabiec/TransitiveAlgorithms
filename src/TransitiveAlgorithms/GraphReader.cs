namespace TransitiveAlgorithms
{
    using System.IO;
    using Newtonsoft.Json;

    public static class GraphReader
    {
        public static int[,] ReadGraphFromJson(string jsonfilePath)
        {
            using (var streamReader = new StreamReader(jsonfilePath))
            {
                return JsonConvert.DeserializeObject<int[,]>(streamReader.ReadToEnd());
            }
        }
    }
}
