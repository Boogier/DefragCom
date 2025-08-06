namespace DefragCom;

internal class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        Console.WriteLine("Starting.");

        //Console.ReadLine();

        /*
         * PowerShell script to extract necessary data for defrag
         
        ##################
        Get-Disk | ForEach-Object {
           $disk = $_
           Get-Partition -DiskNumber $disk.Number | ForEach-Object {
               $partition = $_

               $volume = Get-Volume -Partition $partition

               if ($volume.DriveLetter -eq "D") {
                   [PSCustomObject]@{
                       DriveLetter     = $volume.DriveLetter
                       FileSystem      = $volume.FileSystem
                       SizeGB          = "{0:N2}" -f ($volume.Size / 1GB)
                       Label           = $volume.FileSystemLabel
                       HealthStatus    = $volume.HealthStatus
                       Path = $volume.Path
                       DiskGuid = $disk.Guid
                       PartitionGuid = $partition.Guid
                   }
               }
           }
        }  
        #######

         */
        var partitionGuid = new Guid("31729145-7145-4e9a-b694-6f3b25c6d13b");
        var diskGUID = new Guid("8651ff39-b3d8-4c51-a69d-be961a04e738");
        var volumePath = "\\\\?\\Volume{31729145-7145-4e9a-b694-6f3b25c6d13b}\\";

        var f = new DefragTestPage();
        f.LoadDefragCOM(partitionGuid, diskGUID, volumePath);

        Console.WriteLine("Done");
        Console.ReadLine();
    }
}