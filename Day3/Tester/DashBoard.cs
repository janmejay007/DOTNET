using IDetails;
namespace Tester{
    public class DashBoard : ICustomerDetails , IOrderDetails, IDisposable {
        private int financialYear;
        private string department;

        private bool disposedValue;
        
         public int FinancialYear{
            get{return this.financialYear;}
            set{this.financialYear=value;}
         }

         public DashBoard(){

         }

         public DashBoard(int fy,string dept){
            this.financialYear=fy;
            this.department=dept;
         }

        public override string ToString()
        {
            string data=String.Format("{0},{1}",this.financialYear,this.department);
            return data;
        }

        void ICustomerDetails.ShowDetails(){
            Console.WriteLine("showing customer details");
        }

        void IOrderDetails.ShowDetails(){
            Console.WriteLine("showing order details");
        }

        ~DashBoard(){
            //autocleanup
            //release resources before object goes out of memory
        }

        

        public void Dispose(){
            
            GC.SuppressFinalize(this);

        }

        

 
      

    }
}