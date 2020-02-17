using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.ModelBinding;

namespace Shared
{
    public class getErrors
    {
        public static string getErrorMessagesFor(System.Web.ModelBinding.ModelStateDictionary état)
        {
            List<String> erreurs = new List<String>();
            string messages = string.Empty;
            if (!état.IsValid)
            {
                foreach (ModelState modelState in état.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        erreurs.Add(getErrorMessageFor(error));
                    }
                }
                foreach (string message in erreurs)
                {
                    messages += string.Format("[{0}]", message);
                }
            }
            return messages;
        }
        public static string getErrorMessageFor(ModelError error)
        {
            if (error.ErrorMessage != null && error.ErrorMessage.Trim() != string.Empty)
            {
                return error.ErrorMessage;
            }
            if (error.Exception != null && error.Exception.InnerException == null &&
           error.Exception.Message != string.Empty)
            {
                return error.Exception.Message;
            }
            if (error.Exception != null && error.Exception.InnerException != null &&
           error.Exception.InnerException.Message != string.Empty)
            {
                return error.Exception.InnerException.Message;
            }
            return string.Empty;
        }

       
    }
}
