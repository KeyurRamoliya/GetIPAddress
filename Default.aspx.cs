using System;

namespace GetIPAddress
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ipAdd;
            GetIpValue(out ipAdd);

            string userip;
            GetIpAddress(out userip);
        }

        //Method 1 to get IP Address visitor
        private void GetIpValue(out string ipAdd)
        {
            ipAdd = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (string.IsNullOrEmpty(ipAdd))
            {
                ipAdd = Request.ServerVariables["REMOTE_ADDR"];
            }
            else
            {
                lblIPAddress.Text = ipAdd;
            }
        }

        //Method 2 to get IP Address of visitor
        private void GetIpAddress(out string userip)
        {
            userip = Request.UserHostAddress;
            if (Request.UserHostAddress != null)
            {
                Int64 macinfo = new Int64();
                string macSrc = macinfo.ToString("X");
                if (macSrc == "0")
                {
                    if (userip == "127.0.0.1")
                    {
                        Response.Write("visited Localhost!");
                    }
                    else
                    {
                        lblIPAdd.Text = userip;
                    }   
                }
            }
        }
    }
}