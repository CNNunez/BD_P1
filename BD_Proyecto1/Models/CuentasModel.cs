//
//    This is the the model to handel the result.
//

using Methods;

namespace BD_Proyecto1.Models
{
    public class CuentasModel
    {
        // Attribute
        public string Result { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

        // Init
        // ... this inicialize the textbox
        public CuentasModel()
        {
            Result = "-------";
        }

        // Method
        // ... this puts the result in the textbox
        public string Get_Result()
        {
            ClassMethods myMethod = new ClassMethods();
            Result = myMethod.Get_Phrase();
            return Result;
        }

        // ... to login
        public bool Login()
        {
            ClassMethods myMethod = new ClassMethods();
            bool login = false;
            return login;
        }
    }
}