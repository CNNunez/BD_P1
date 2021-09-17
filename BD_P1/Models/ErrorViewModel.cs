//
//    This is the the model to handel the result.
//

using Methods;

namespace BD_P1.Models
{
    public class ChallengeModel
    {
        // Attribute
        public string Result { get; set; }

        // Init
        // ... this inicialize the textbox
        public ChallengeModel()
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
    }
}