internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao kich thuoc cua ma tran vuong: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] myarry = new int[n,n];
        Console.WriteLine("Nhap vao gia tri cac phan tu trong mang:");
        for (int row = 0; row < myarry.GetLength(0);row++)
        {
            for (int col = 0; col < myarry.GetLength(1);col++)
            {
                Console.WriteLine("Nhap vao gia tri cua phan tu ({0},{1}): ",row,col);
                myarry[row,col] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int sum = 0;
        Console.WriteLine("Mang da nhap la:");
        for (int row = 0; row < myarry.GetLength(0);row++)
        {
            for (int col = 0; col < myarry.GetLength(1);col++)
            {
                if (col == row){
                    sum += myarry[row,col];
                }
                Console.Write(myarry[row,col]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Tong gia tri duong cheo cua ma tran vuong la: {0}",sum);
    }
}