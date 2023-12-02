namespace JasonUtilities
{
    public class Helper
    {
        public static string HelperMethod1(string machineName, int storeNumber) 
        {
            string result=string.Format("{0}_{1}.txt",machineName,storeNumber);


            return result; 
        }

        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Not fully implemented.");
        }

        public static int countFilesInBlobFolder(string blobFolder)
        {
            if(blobFolder == "test")
            {
                return 1;
            }
            throw new NotImplementedException("Not fully implemented");
        }


    }
}