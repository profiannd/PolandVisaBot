using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using DecaptcherLib;



namespace DecaptcherAPI
{

	class Class1
	{
    ////////////////////////
    // ADD Reference to DecaptcherLib.dll
    ////////////////////////
    //Send captcha.
    //Parameters:
    //hostname   - IN ip or the host name of decaptcher.
    //port       - IN your port.
    //login      - IN your login.
    //pwd        - IN your password.
    //pict        - IN buffer with picture
    //p_pict_to   - IN/OUT timeout specifier to be used, on return - really used specifier
    //			  ptoDEFAULT		= 0, use default server's timeout
    //			  ptoLONG			= 1, wait infinitely (be cautious with this) 
    //			  pto30SEC		    = 2, 30 seconds
    //			  pto60SEC   		= 3, 60 seconds
    //			  pto90SEC  		= 4, 90 seconds
    //p_pict_type - IN/OUT	type specifier to be used, on return - really used specifier ptUNSPECIFIED	= 0, picture type is unspecified, no special tratment is needed
    //text        - OUT returned text, the buffer must be preallocated size 100 byte or more
    //major_id    - OUT major part of the picture ID
    //minor_id 	- OUT minor part of the picture ID
    //Return Value:
    // If the function succeeds, the return value is 0 - ccERR_OK.
    // If the function fails, the return value is <0
    // ccERR_GENERAL		= -1   - server-side error, better to call ccproto_login() again.
    // ccERR_STATUS        = -2   - local error. either ccproto_init() or ccproto_login() has not been successfully called prior to ccproto_picture(), need ccproto_init() and ccproto_login() to be called.
    // ccERR_NET_ERROR     = -3   - network troubles, better to call ccproto_login() again.
    // ccERR_TEXT_SIZE     = -4   - size of the text returned is too big.
    // ccERR_OVERLOAD      = -5   - temporarily server-side error, server's overloaded, wait a little before sending a new picture.
    // ccERR_BALANCE       = -6   - not enough funds to process a picture, balance is depleted.
    // ccERR_TIMEOUT       = -7   - picture has been timed out on server (payment not taken).
    // ccERR_BAD_PARAMS	   = -8 - bad parameters
    // ccERR_UNKNOWN       = -200 - unknown error, better to call ccproto_login() again.
    //-201  Error incorrect length hostname or password or login
    //-202  Error allocate memory
    //-203  Error convert characters
    //-204  Error init ctx
    ////////////////////////
    //int RecognizePicture(string hostname, uint port, string login, string pwd, byte[] pict, out uint p_pict_to, out uint p_pict_type, out string text, out uint major_id, out uint minor_id)
    ////////////////////////

    //Get balance.
    //Parameters:
    //hostname   -IN ip or the host name of decaptcher.
    //port       -IN  your port.
    //login      -IN your login.
    //pwd        -IN your password.
    //balance	 -OUT this is the pointer to the balance value
    //Return Value:
    // If the function succeeds, the return value is 0 - ccERR_OK.
    // If the function fails, the return value is <0
    // ccERR_GENERAL		= -1   - server-side error, better to call ccproto_login() again.
    // ccERR_STATUS        = -2   - local error. either ccproto_init() or ccproto_login() has not been successfully called prior to ccproto_picture(), need ccproto_init() and ccproto_login() to be called.
    // ccERR_NET_ERROR     = -3   - network troubles, better to call ccproto_login() again.
    // ccERR_TEXT_SIZE     = -4   - size of the text returned is too big.
    // ccERR_OVERLOAD      = -5   - temporarily server-side error, server's overloaded, wait a little before sending a new picture.
    // ccERR_BALANCE       = -6   - not enough funds to process a picture, balance is depleted.
    // ccERR_TIMEOUT       = -7   - picture has been timed out on server (payment not taken).
    // ccERR_BAD_PARAMS	   = -8 - bad parameters
    // ccERR_UNKNOWN       = -200 - unknown error, better to call ccproto_login() again.
    //-201  Error incorrect length hostname or password or login
    //-202  Error allocate memory
    //-203  Error convert characters
    //-204  Error init ctx
    ////////////////////////
    //int Balance(string hostname, uint port, string login, string pwd, out double balance)
    ////////////////////////

    //Report picture as bad.
    //Parameters:
    //hostname   -IN ip or the host name of decaptcher.
    //port       -IN  your port.
    //login      -IN your login.
    //pwd        -IN your password.
    //major_id   -IN major part of the picture ID.
    //minor_id   -IN minor part of the picture ID.
    //Return Value:
    // If the function succeeds, the return value is 0 - ccERR_OK.
    // If the function fails, the return value is <0
    // ccERR_GENERAL		= -1   - server-side error, better to call ccproto_login() again.
    // ccERR_STATUS        = -2   - local error. either ccproto_init() or ccproto_login() has not been successfully called prior to ccproto_picture(), need ccproto_init() and ccproto_login() to be called.
    // ccERR_NET_ERROR     = -3   - network troubles, better to call ccproto_login() again.
    // ccERR_TEXT_SIZE     = -4   - size of the text returned is too big.
    // ccERR_OVERLOAD      = -5   - temporarily server-side error, server's overloaded, wait a little before sending a new picture.
    // ccERR_BALANCE       = -6   - not enough funds to process a picture, balance is depleted.
    // ccERR_TIMEOUT       = -7   - picture has been timed out on server (payment not taken).
    // ccERR_BAD_PARAMS	   = -8 - bad parameters
    // ccERR_UNKNOWN       = -200 - unknown error, better to call ccproto_login() again.
    //-201  Error incorrect length hostname or password or login
    //-202  Error allocate memory
    //-203  Error convert characters
    //-204  Error init ctx
    ////////////////////////
    //int BadPicture(string hostname, uint port, string login, string pwd, uint major_id, uint minor_id)
    ////////////////////////

    //Get load system Decaptcher.
    //Parameters:
    //hostname   -IN ip or the host name of decaptcher.
    //port       -IN  your port.
    //login      -IN your login.
    //pwd        -IN your password.
    //load		 -OUT current load Decaptcher
    //Return Value:
    // If the function succeeds, the return value is 0 - ccERR_OK.
    // If the function fails, the return value is <0
    // ccERR_GENERAL		= -1   - server-side error, better to call ccproto_login() again.
    // ccERR_STATUS        = -2   - local error. either ccproto_init() or ccproto_login() has not been successfully called prior to ccproto_picture(), need ccproto_init() and ccproto_login() to be called.
    // ccERR_NET_ERROR     = -3   - network troubles, better to call ccproto_login() again.
    // ccERR_TEXT_SIZE     = -4   - size of the text returned is too big.
    // ccERR_OVERLOAD      = -5   - temporarily server-side error, server's overloaded, wait a little before sending a new picture.
    // ccERR_BALANCE       = -6   - not enough funds to process a picture, balance is depleted.
    // ccERR_TIMEOUT       = -7   - picture has been timed out on server (payment not taken).
    // ccERR_BAD_PARAMS	   = -8 - bad parameters
    // ccERR_UNKNOWN       = -200 - unknown error, better to call ccproto_login() again.
    //-201  Error incorrect length hostname or password or login
    //-202  Error allocate memory
    //-203  Error convert characters
    //-204  Error init ctx
    ////////////////////////
    //int SystemDecaptcherLoad(string hostname, uint port, string login, string pwd, out uint load)
    ////////////////////////

    //Recognize Asirra captcha.
    //Parameters:
    //hostname   - IN ip or the host name of decaptcher.
    //port       - IN your port.
    //login      - IN your login.
    //pwd        - IN your password.
    //pict        - IN buffer with picture
    //p_pict_to   - IN/OUT timeout specifier to be used, on return - really used specifier
    //			  ptoDEFAULT		= 0, use default server's timeout
    //			  ptoLONG			= 1, wait infinitely (be cautious with this) 
    //			  pto30SEC		    = 2, 30 seconds
    //			  pto60SEC   		= 3, 60 seconds
    //			  pto90SEC  		= 4, 90 seconds
    //p_pict_type - IN/OUT	type specifier to be used, on return - really used specifier ptUNSPECIFIED	= 0, picture type is unspecified, no special tratment is needed
    //text        - OUT returned text, the buffer must be preallocated size 100 byte or more
    //major_id    - OUT major part of the picture ID
    //minor_id 	- OUT minor part of the picture ID
    //Return Value:
    // If the function succeeds, the return value is 0 - ccERR_OK.
    // If the function fails, the return value is <0
    // ccERR_GENERAL		= -1   - server-side error, better to call ccproto_login() again.
    // ccERR_STATUS        = -2   - local error. either ccproto_init() or ccproto_login() has not been successfully called prior to ccproto_picture(), need ccproto_init() and ccproto_login() to be called.
    // ccERR_NET_ERROR     = -3   - network troubles, better to call ccproto_login() again.
    // ccERR_TEXT_SIZE     = -4   - size of the text returned is too big.
    // ccERR_OVERLOAD      = -5   - temporarily server-side error, server's overloaded, wait a little before sending a new picture.
    // ccERR_BALANCE       = -6   - not enough funds to process a picture, balance is depleted.
    // ccERR_TIMEOUT       = -7   - picture has been timed out on server (payment not taken).
    // ccERR_BAD_PARAMS	   = -8 - bad parameters
    // ccERR_UNKNOWN       = -200 - unknown error, better to call ccproto_login() again.
    //-201  Error incorrect length hostname or password or login
    //-202  Error allocate memory
    //-203  Error convert characters
    //-204  Error init ctx
    ////////////////////////
    //int RecognizeAsirra(string hostname, uint port, string login, string pwd, byte[][] pict, out uint p_pict_to, out uint p_pict_type, out string text, out uint major_id, out uint minor_id)
    ////////////////////////
	[STAThread]
		static void Main(string[] args)
		{

			int ret;
			
			uint p_pict_to;
            uint p_pict_type;
            uint major_id;
            uint minor_id;
            uint port;
            uint load;
            string host;
            string name;
            string passw;
            string answer_captcha;
			double balance;
            

       // zzz

            p_pict_to = 0;
            p_pict_type = 0;
            major_id = 0;
            minor_id = 0;
            load = 0;

            FileStream fs = new FileStream(@"c:\MyCaptchaImage.jpg", FileMode.Open);

			byte[] buffer = new byte[fs.Length];
			fs.Read(buffer, 0, buffer.Length);
			fs.Close();

            byte[][] assira = new byte[12][];
            FileStream fs_assira;
            for (int i = 0; i < assira.Length; i++)
            {
                string pth = "assira\\asi";
                pth += (i + 1);
                pth += ".jpg";

                fs_assira = new FileStream(pth, FileMode.Open);

                assira[i] = new byte[fs_assira.Length];
                fs_assira.Read(assira[i], 0, assira[i].Length);
                fs_assira.Close();
                fs_assira.Dispose();
            }


            //Get your balance
            ret = DecaptcherLib.Decaptcher.Balance(host, port, name, passw, out balance);

            //Get load system Decaptcher.
            ret = DecaptcherLib.Decaptcher.SystemDecaptcherLoad(host, port, name, passw, out load);

            //Send captcha to Decaptcher
            ret = DecaptcherLib.Decaptcher.RecognizePicture(host, port, name, passw, buffer, out p_pict_to,out p_pict_type,out answer_captcha,out major_id,out minor_id);

            //Recognize Asirra captcha.
            ret = DecaptcherLib.Decaptcher.RecognizeAsirra(host, port, name, passw, assira, out p_pict_to, out p_pict_type, out answer_captcha, out major_id, out minor_id);
            
            
            //Report picture as bad.
            //ret = DecaptcherLib.Decaptcher.BadPicture(host, port, name, passw, minor_id, major_id);

            Console.WriteLine(ret);

		
		}
	}
}
