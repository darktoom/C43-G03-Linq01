using System.Xml;
using static C43_G03_Linq01.ListGenerator;
namespace C43_G03_Linq01

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region var%dynamic
            ////string data = "ahmed";
            ////var data = "ahmed";
            ////data=null;

            //dynamic data = "ali";
            //data = 1;
            //data=null;
            //dynamic x;
            //dynamic y =null;
            //Console.WriteLine(y);



            #endregion
            #region Extenion method
            //int x = 12345;
            //int y =x.reverse();
            //Console.WriteLine(y);
            #endregion
            #region  type
            //  Employee employee = new Employee() { Id = 123, Name = "ahmed", salary = 1000 };
            //object emp01 = new { id = 10, name = "hatem" ,salary=4100};

            //var emp03 = new {Id=10,name ="may",salary=1450};
            //Console.WriteLine(emp03.GetType().Name);
            #endregion
            #region linq intro
            //  List<int> numbers = new List<int>() {1,2,3,4,5,6 };
            //List<int> odd=  numbers.Where(num=>num%2==1).ToList();
            //  foreach (int num in odd) {
            //      Console.WriteLine(num);

            //  }
            #endregion
            #region linq syntax
            //            // static
            //            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            //            var odd = Enumerable.Where(numbers,x=>x%2==1);

            //// extesntion
            //            odd=numbers.Where(x=>x%2==1) ;
            //            foreach (int i in odd) {

            //                Console.WriteLine(i);

            //            }


            //            //query 
            //            var oodnumbers=from n in numbers
            //                           where n%2==1
            //                           select n;

            //            foreach (int i in oodnumbers) {

            //                Console.WriteLine($"{i}");

            //            }




            #endregion
            #region excution ways

            //List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10 };
            ////deferred excution
            //var odd = numbers.Where(x => x % 2 == 1);
            //numbers.AddRange(new int[] {11,12,13,14,15} );
            //foreach (int x in odd) {

            //    Console.WriteLine(x); //// 1 3 5 7 9 11 13 15

            //}

            //// immediate excution
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var odd = numbers.Where(x => x % 2 == 1).ToList();
            //numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });
            //foreach (int x in odd)
            //{

            //    Console.WriteLine(x); // 1 3 5 7 9

            //}

            #endregion
            #region data setup
            //Console.WriteLine(ProductsList[0]);
            //Console.WriteLine(CustomerList[0]);

            #endregion
            #region where
            //var result = ProductsList.Where(x => x.UnitsInStock == 0);
            //foreach (var item in result) {
            //    Console.WriteLine(item);

            //}
            //var ressult = from p in ProductsList
            //              where p.UnitsInStock == 0
            //              select p;
            //foreach (var r in ressult)
            //{
            //    Console.WriteLine(r);
            //}


            //var result = ProductsList.Where(x => x.Category == "Meat/Poultry" && x.UnitsInStock >0);
            //foreach (var item in result) {
            //    Console.WriteLine(item);

            //}

            //var result =from P in ProductsList
            //            where P.Category== "Meat/Poultry" &&P.UnitsInStock == 0
            //            select P;
            //foreach (var item in result) {

            //    Console.WriteLine(item);

            //}

            //var result = ProductsList.Where((x, y) => y < 10 && x.UnitsInStock == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}


            #endregion
            #region select
            //var rsult = ProductsList.Select(x => x.ProductName);

            //foreach (var rs in rsult) {

            //    Console.WriteLine(rs);
            //}

            //var result=from P in ProductsList
            //           select P.ProductName;
            //foreach (var item in result) {

            //    Console.WriteLine(item);
            //}

            //var rs = CustomerList.Select(x => x.CustomerName);
            //foreach (var r in rs) {

            //    Console.WriteLine(r);
            //}

            //var rs=from c in CustomerList
            //       select c.CustomerName;
            //foreach (var item in rs) {
            //    Console.WriteLine(item);

            //  }

            //var rs = CustomerList.SelectMany(x => x.Orders);
            //foreach (var r in rs) {
            //    Console.WriteLine(r);

            //}

            //var rs = from c in CustomerList
            //         from o in c.Orders 
            //         select o;
            //foreach (var r in rs) {
            //    Console.WriteLine(r);

            //}

            //var rs = ProductsList.Select(x =>new {  x.ProductID,  x.ProductName } );
            //foreach (var item in rs) {
            //    Console.WriteLine(item);
            //}


            //var rs = from p in ProductsList
            //         select new
            //         {
            //             productname = p.ProductName,
            //             productid = p.ProductID,

            //         };
            //foreach (var item in rs) {
            //    Console.WriteLine(item);
            //}

            //var rs = ProductsList.Where(x => x.UnitsInStock > 0).Select(x => new { id = x.ProductID, name = x.ProductName, old = x.UnitPrice, newprice = x.UnitPrice -x.UnitPrice * 0.1m });


            //foreach (var r in rs) {
            //    Console.WriteLine(r);

            //}
            //var rs = from p in ProductsList
            //         where p.UnitsInStock > 0
            //         select new { 
            //         id =p.ProductID, quantity = p.UnitsInStock, unitPrice = p.UnitPrice,
            //         newprice=p.UnitPrice-(p.UnitPrice*.01m)


            //         };
            //foreach (var r in rs) {

            //    Console.WriteLine(r);
            //}

            //var rs = ProductsList.Where(p => p.UnitsInStock > 0).Select((p, i) => new
            //{
            //    Index = i,
            //    name=p.ProductName


            //});

            //foreach (var r in rs) {
            //    Console.WriteLine(r);
            //}



            #endregion
            #region order by
            //var result = ProductsList.OrderBy(p => p.UnitPrice);
            //foreach (var item in result) {
            //    Console.WriteLine(item);
            //}
            //var res=from p in ProductsList
            //        orderby p.UnitPrice
            //        select p;

            //foreach (var item in res) {
            //    Console.WriteLine(item); 

            //}

            //var result  =ProductsList.OrderByDescending(p=>p.UnitPrice);
            //foreach (var item in result) {

            //    Console.WriteLine(item  );

            //}

            //var res=from p in ProductsList
            //        orderby p.UnitPrice descending
            //        select p;
            //foreach (var item in res) {

            //    Console.WriteLine(item);
            //}
            //var result = ProductsList .OrderBy (x => x.UnitPrice).ThenBy(p=>p.UnitsInStock);
            //foreach (var item in result)
            //{

            //    Console.WriteLine(item);
            //}

            #endregion


            #region assiginment



            // var result = ProductsList.Where(x => x.UnitsInStock == 0);

            // result =ProductsList.Where(x=>x.UnitsInStock > 0&&x.UnitPrice>3m);

            // result = ProductsList.OrderBy(x => x.ProductName);

            // result =ProductsList.OrderByDescending(x => x.UnitsInStock);

            // result =ProductsList.OrderByDescending(x=>x.Category).ThenByDescending(x=>x.UnitPrice);
            //var res =ProductsList.Select(x => x.ProductName);

            // var result = ProductsList.Select(x => new { price = x.UnitPrice,name=x.ProductName });

          //  var result = CustomerList.SelectMany(x => x.Orders).Where(x => x.Total < 500);
          //var res = CustomerList.SelectMany(x => x.Orders).Where(x => x.OrderDate.Year >= 1998);
            //foreach (var item in res) {
            //    Console.WriteLine(item);
            
            //}
            #endregion

        }
    }
}
